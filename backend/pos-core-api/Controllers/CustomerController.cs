﻿using System;
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
                List<CustomerModel> output = DataAccess.Instance.Customer.Get();
                return Ok(output);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET: api/Customer/ID
        [HttpGet("{customerID}")]
        public IActionResult Get(String customerID)
        {
            try
            {
                return Ok(DataAccess.Instance.Customer.Get(customerID));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        // POST: api/Customer
        [HttpPost]
        public IActionResult Post([FromBody] CustomerUpdateModel cust)
        {
            try
            {
               return Ok( DataAccess.Instance.Customer.Insert(cust));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT: api/Customer/{custID}
        [HttpPut]
        public IActionResult Put([FromBody] CustomerUpdateModel cust)
        {
            try
            {
                if (DataAccess.Instance.Customer.Update(cust) > 0)
                    return Ok();
                else
                    return StatusCode(404);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // Delete: api/Customer/{custID}
        [HttpDelete("{custID}")]
        public IActionResult Delete(uint custID)
        {
            try
            {
                DataAccess.Instance.Customer.Delete(custID);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}