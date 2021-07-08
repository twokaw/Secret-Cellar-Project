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

        [HttpGet("Order/{order}")]
        public IActionResult GetOrder(uint order, bool includeHistory = false)
        {
            try
            {
                return Ok(DataAccess.Instance.CustomerOrder.Get(order, includeHistory));
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] CustomerOrder cust)
        {
            try
            {
               return Ok( DataAccess.Instance.CustomerOrder.Insert(cust));
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] CustomerOrder cust)
        {
            try
            {
                if (DataAccess.Instance.CustomerOrder.Update(cust) > 0)
                    return Ok();
                else
                    return StatusCode(404);
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
            try
            {
                DataAccess.Instance.CustomerOrder.Delete(custID);
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