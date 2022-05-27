using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Shared;
using pos_core_api.ORM;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerOrderController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(bool includeHistory = false)
        {
            try
            {
                List<CustomerOrder> output = DataAccess.Instance.CustomerOrder.Get(includeHistory);
                return Ok(output);
            }
            catch(Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{customerID}")]
        public IActionResult Get(uint customerID, bool includeHistory = false)
        {
            try
            {
                return Ok(DataAccess.Instance.CustomerOrder.Get(customerID, includeHistory));
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("OrderItem/{orderItem}")]
        public IActionResult GetOrder(uint orderItem, bool includeHistory = false)
        {
            try
            {
                return Ok(DataAccess.Instance.CustomerOrder.GetCustomerItem(orderItem));
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("{customerID}")]
        public IActionResult Post(uint customerID, [FromBody] CustomerOrderItem cust)
        {
            try
            {
                return Ok( DataAccess.Instance.CustomerOrder.Insert(customerID, cust));
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{customerID}")]
        public IActionResult Put(uint customerID, uint transactionId, [FromBody] CustomerOrderItem cust)
        {
            try
            {
                CustomerOrderItem temp = DataAccess.Instance.CustomerOrder.GetCustomerItem(cust.CustomerOrderItemID);
                if (temp == null)
                    return Post(customerID, cust);

                Transaction transaction = null;

                if (transactionId > 0)
                    transaction = DataAccess.Instance.Transaction.GetTransaction(transactionId);

                long id = DataAccess.Instance.CustomerOrder.Update(cust, customerID, transaction);

                if (id > 0)
                    return Ok(id);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{custOrdID}")]
        public IActionResult Delete(uint custOrdID)
        {
            try
            {
                DataAccess.Instance.CustomerOrder.Delete(custOrdID);
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