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
        public IActionResult Get()
        {
            try
            {
                List<Customer> output = DataAccess.Instance.CustomerOrder.Get();
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
                return Ok(DataAccess.Instance.CustomerOrder.Get(customerID));
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }

        // GET: api/Customer/Phone/{phone}
        [HttpGet("Order/{order}")]
        public IActionResult GetOrder(uint order)
        {
            try
            {
                return Ok(DataAccess.Instance.CustomerOrder.Get(order));
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
                return StatusCode(500, ex.Message);
            }
        }

        // POST: api/Customer
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

        // PUT: api/Customer/{custID}
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