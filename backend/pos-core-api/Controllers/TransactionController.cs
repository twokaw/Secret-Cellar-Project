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
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
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
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            };
        }

        // Get call to be used when barcode on receipt is scanned
        //Get: api/Transaction/Suspended
        [HttpGet("Suspended/")]
        public ActionResult GetSuspended()
        {
            try
            {
                return Ok(DataAccess.Instance.Transaction.GetSuspendedTransactions());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            };
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
                // If there is a Invoice ID and the Transaction exists then Update the Transaction else insert it
                if(transaction.InvoiceID > 0 && DataAccess.Instance.Transaction.GetTransaction(transaction.InvoiceID, false, false) != null)
                    return Ok(DataAccess.Instance.Transaction.UpdateTransaction(transaction)); 
                else
                    return Ok(DataAccess.Instance.Transaction.InsertTransaction(transaction));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            };
         }

        /// <summary>
        /// Insert a new transaction 
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        [HttpDelete("/item/{receiptId}")]
        public IActionResult DeleteItem(uint receiptId, uint itemid, int qty = -1, bool returnQty = false)
        {
            if (qty == 0)
                return StatusCode(400, "Invalid Qty: 0");

            Transaction transaction = DataAccess.Instance.Transaction.GetTransaction(receiptId, false, false);

            if (transaction == null)
                return StatusCode(400, "Missing Transaction");

            Item item = transaction.Items.FirstOrDefault(z => z.Id == itemid);

            if (item == null)
                return StatusCode(400, "Missing Transaction Item");

            if (item.NumSold == 0)
                return StatusCode(400, $"Item already returned");

            if (item.NumSold < qty)
                return StatusCode(400, $"Insuffiencent receipt Qty {item.NumSold} < {qty}");

            qty = (qty == -1) ? (int)item.NumSold : qty;

            if (returnQty)
                DataAccess.Instance.Transaction.AddInventoryQty(item, qty);

            DataAccess.Instance.Transaction.UpdateItemQty(receiptId, itemid, (int)(item.NumSold - qty));

            try
            {
                // Return the refund qty * ((price * Tax * localTax) + bottle deposit * bottles)
                return Ok((qty  
                           * (item.Price 
                           * (1 + (item.NonTaxable ? 0 : item.SalesTax) 
                                + (item.NonTaxableLocal ? 0 : item.LocalSalesTax)
                           + item.Bottles * item.BottleDeposit)
                             )).ToString());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            };
        }
    }
}
