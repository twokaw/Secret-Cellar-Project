using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Shared;
using pos_core_api.ORM;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {        
        // Gets list of all transactions within date period. Format: YYYY-MM-DD HH:MM:SS
        // GET: api/Transaction?start= date&end= date
        [HttpGet]
        public ActionResult Get(DateTime start, DateTime end)
        {
            try
            {
                return Ok(DataAccess.Instance.Transaction.GetTransactions(start, end));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        // Get call to be used when barcode on receipt is scanned
        //Get: api/Transaction/receiptID
        [HttpGet("{receiptID}")]
        public ActionResult Get(uint receiptID)
        {
            try
            {
                return Ok(DataAccess.Instance.Transaction.GetTransaction(receiptID));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        // Get call to be used when barcode on receipt is scanned
        //Get: api/Transaction/Suspended
        [HttpGet("Suspended/")]
        public ActionResult GetSuspended(uint customerID = 0)
        {
            try
            {
                if(customerID > 0)
                    return Ok(DataAccess.Instance.Transaction.GetSuspendedTransactions(customerID));
                else
                    return Ok(DataAccess.Instance.Transaction.GetSuspendedTransactions());
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        // Get call to be used when barcode on receipt is scanned
        //Get: api/Transaction/Suspended
        [HttpGet("Suspended/Customer/{customerID}")]
        public ActionResult GetCustomerSuspended(uint customerID)
        {
            try
            {
                return Ok(DataAccess.Instance.Transaction.GetSuspendedTransactions(customerID));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
        // Returns a list of all payment methods
        //Get: api/Transaction/PaymentMethods
        [HttpGet("PaymentMethods")]
        public ActionResult GetPaymentMethods()
        {
            try
            {
                return Ok(DataAccess.Instance.Transaction.GetPaymentMethods());
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        // Update paymentmenthod and Returns a list of all payment methods
        //Put: api/Transaction/PaymentMethod
        [HttpPut("PaymentMethods")]
        public ActionResult PutPaymentMethod([FromBody] PaymentMethod paymentMethod)
        {
            try
            {
                return Ok(DataAccess.Instance.Transaction.PutPaymentMethod(paymentMethod));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        // Get transaction 
        //Get: api/Transaction/Customer/{customerID}
        [HttpGet("Customer/{customerID}")]
        public ActionResult GetCustomer(uint customerID, DateTime start, DateTime end, bool includeItems, bool includePayments)
        {
            try
            {
                return Ok(DataAccess.Instance.Transaction.GetCustomerTransactions(customerID, start, end, includeItems, includePayments));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        /// <summary>
        /// Insert a new transaction 
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Transaction transaction)
        {
            try
            {
                Transaction previousTransaction = DataAccess.Instance.Transaction.GetTransaction(transaction.InvoiceID, true, true);
                // If there is a Invoice ID and the Transaction exists then Update the Transaction else insert it
                if (transaction.InvoiceID > 0 && previousTransaction != null)
                    return Ok(DataAccess.Instance.Transaction.UpdateTransaction(transaction, previousTransaction)); 
                else
                    return Ok(DataAccess.Instance.Transaction.InsertTransaction(transaction));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
        
        /// <summary>
        /// Delete transaction 
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        [HttpDelete("{receiptId}")]
        public IActionResult DeleteTransaction(uint receiptId)
        {
            try
            {
                Transaction transaction = DataAccess.Instance.Transaction.GetTransaction(receiptId,false,true);

                if (transaction == null)
                    return BadRequest("Missing Transaction");

                if (transaction.Payments.Count > 0 )
                    return StatusCode(500, "Refund Payments before deleting"); 

                DataAccess.Instance.Transaction.DeleteTransaction(receiptId);

                // Return the refund qty * ((price * Tax * localTax) + bottle deposit * bottles)
                return Ok();
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        /// <summary>
        /// Insert a new transaction 
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        [HttpDelete("payment/{receiptId}/{payId}")]
        public IActionResult DeleteTransaction(uint receiptId, uint payId)
        {
            try
            {
                Transaction transaction = DataAccess.Instance.Transaction.GetTransaction(receiptId, false, true);

                if (transaction == null)
                    return BadRequest("Missing Transaction");

                if (transaction.Payments.FirstOrDefault (x => x.PayId == payId ) == null)
                    return StatusCode(500, "Payment is not part of this transaction");

                DataAccess.Instance.Transaction.DeletePayment(payId);

                return Ok();
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
        /// <summary>
        /// Delete Transaction
        /// </summary>
        /// <returns></returns>
        [HttpDelete("item/{receiptId}")]
        public IActionResult DeleteItem(uint receiptId, uint itemid, int qty = -1, bool returnQty = false, bool restock = false)
        {

            try
            {
                if (qty == 0)
                    return BadRequest("Invalid Qty: 0");

                Transaction transaction = DataAccess.Instance.Transaction.GetTransaction(receiptId, true, false);

                if (transaction == null)
                    return BadRequest("Missing Transaction");

                Item item = transaction.Items.FirstOrDefault(z => z.Id == itemid);

                if (item == null)
                    return BadRequest("Missing Transaction Item");

                if (item.NumSold == 0)
                    return BadRequest($"Item already returned");

                if (item.NumSold < qty)
                    return BadRequest($"Insuffiencent receipt Qty {item.NumSold} < {qty}");

                qty = (qty == -1) ? (int)item.NumSold : qty;

                if (returnQty)
                {
                    DataAccess.Instance.Transaction.UpdateItemQty(receiptId, itemid, item.QtySold, (uint)(item.QtyRefunded + qty));
                    
                    if(restock)
                        DataAccess.Instance.Transaction.AddInventoryQty(item, qty);
                }
                else
                    DataAccess.Instance.Transaction.UpdateItemQty(receiptId, itemid, (uint)(item.NumSold - qty), item.QtyRefunded);    

                // Return the refund qty * ((price * Tax * localTax) + bottle deposit * bottles)
                return Ok((qty  
                           * (item.Price 
                           * (1 + (item.NonTaxable ? 0 : item.SalesTax) 
                                + (item.NonTaxableLocal ? 0 : item.LocalSalesTax)
                           + item.Bottles * item.BottleDeposit)
                             )).ToString());
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
    }
}
