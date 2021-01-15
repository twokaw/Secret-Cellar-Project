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
                List<Customer> output = DataAccess.Instance.Customer.Get();
                return Ok(output);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        // Get: api/Customer
        [HttpGet("WithBalance")]
        public IActionResult GetWithBalance()
        {
            try
            {
                List<Customer> output = DataAccess.Instance.Customer.GetWithBalance();
                return Ok(output);
            }
            catch (Exception ex)
            {
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
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        // GET: api/Customer/WithBalance/ID
        [HttpGet("WithBalance/{customerID}")]
        public IActionResult GetWithBalance(uint customerID)
        {
            try
            {
                return Ok(DataAccess.Instance.Customer.GetWithBalance(customerID));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
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