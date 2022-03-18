using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Shared;
using pos_core_api.ORM;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // Get: api/Customer
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Customer> output = DataAccess.Instance.Customer.Get();
                return Ok(output);
            }
            catch(Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }

        // GET: api/Customer/ID
        [HttpGet("{customerID}")]
        public IActionResult Get(uint customerID)
        {
            try
            {
                return Ok(DataAccess.Instance.Customer.Get(customerID));
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }

        // GET: api/Customer/Phone/{phone}
        [HttpGet("Phone/{phone}")]
        public IActionResult Get(string phone)
        {
            try
            {
                return Ok(DataAccess.Instance.Customer.Get(phone));
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }

        // GET: api/Customer/Favorite/
        [HttpGet("Favorite/")]
        public IActionResult GetFavorites()
        {
            try
            {
                return Ok(DataAccess.Instance.Customer.GetCustomerFavorites());
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }

        // GET: api/Customer/Favorite/
        [HttpGet("Favorite/{CustomerID}")]
        public IActionResult GetFavorite(uint CustomerID)
        {
            try
            {
                return Ok(DataAccess.Instance.Customer.GetCustomerFavorites(CustomerID));
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Returns the hash of the data for the customer View. 
        /// </summary>
        /// <returns>
        /// The hash value for the customer view
        /// </returns>
        // GET: api/Customer/Hash
        [HttpGet("Hash", Name = "GetCustomerHash")]
        public IActionResult GetHash()
        {
            try
            {
                return Ok(DataAccess.Instance.Customer.GetCustHash());
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        //  DELETE: api/Customer/Favorite/
        [HttpDelete("Favorite/{CustomerID}/{InventoryID}")]
        public IActionResult DeleteFavorite(uint CustomerID, uint InventoryID)
        {
            try
            {
                DataAccess.Instance.Customer.RemoveCustomerFavorite(CustomerID, InventoryID);
                return Ok();
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }
        // Insert: api/Customer/Favorite/
        [HttpPut("Favorite/{CustomerID}/{InventoryID}")]
        public IActionResult PutFavorite(uint CustomerID, uint InventoryID)
        {
            try
            {
                DataAccess.Instance.Customer.AddCustomerFavorite(CustomerID, InventoryID);
                return Ok();
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }

        // POST: api/Customer
        [HttpPost]
        public IActionResult Post([FromBody] Customer cust)
        {
            try
            {
               return Ok( DataAccess.Instance.Customer.Insert(cust));
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }

        // PUT: api/Customer/{custID}
        [HttpPut]
        public IActionResult Put([FromBody] Customer cust)
        {
            try
            {
                if (DataAccess.Instance.Customer.Update(cust) > 0)
                    return Ok();
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }

        // Delete: api/Customer/{custID}
        [HttpDelete("{custID}")]
        public IActionResult Delete(uint custID)
        {
            List<Transaction> suspendedTransactions = DataAccess.Instance.Transaction.GetSuspendedTransactions();
            List<Transaction> filteredSuspendedTransactions = suspendedTransactions.FindAll((transaction) => { return transaction.CustomerID == custID; });

            if (filteredSuspendedTransactions.Count > 0) { return StatusCode(400, "Customer cannot be deleted, he/she exists in a transaction."); }

            try
            {
                DataAccess.Instance.Customer.Delete(custID);
                return Ok();
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }
    }
}