using Microsoft.AspNetCore.Mvc;
using pos_core_api.ORM;
using Shared;
using System;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        /// <summary>
        /// A get all request that retrieves all the suppliers. 
        /// </summary>
        /// <returns>
        /// Returns a list of supplier. 
        /// </returns>
        // GET: api/Supplier
        [HttpGet()]
        public IActionResult Get(string name = null)
        {
            try
            {
                if(name == null)
                    return Ok(DataAccess.Instance.Supplier.Get());
                else
                    return Ok(DataAccess.Instance.Supplier.Get(name));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        /// <summary>
        /// A get request that retrieves a specific supplier. 
        /// </summary>
        /// <returns>
        /// Returns a list of iventory items. 
        /// </returns>
        // GET: api/Supplier
        [HttpGet("id/{id}", Name = "Get Supplier by ID")]
        public IActionResult GetSupplier(uint id)
        {
            try
            {
                Supplier output = DataAccess.Instance.Supplier.Get(id);

                if (output == null)
                    return BadRequest($"The '{id}' does not exist. ");
                else
                    return Ok(output);
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        /// <summary>
        /// Creates a new Supplier.
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns></returns>
        // PUT: api/Supplier
        [HttpPut]
        public IActionResult Put([FromBody] Supplier supplier)
        {
            try
            {
                return Ok(DataAccess.Instance.Supplier.Update(supplier));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        [HttpPost]
        public IActionResult Insert([FromBody]Supplier supplier)
        {
            try
            {
                return Ok(DataAccess.Instance.Supplier.Insert(supplier));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
    }
}
