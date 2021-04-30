using Microsoft.AspNetCore.Mvc;
using Shared;
using pos_core_api.ORM;
using System;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxController : ControllerBase
    {
        // Get: api/Tax
        [HttpGet]
        public IActionResult GetTax()
        {
            return Ok(DataAccess.Instance.Tax.Get());
        }

        // Get: api/Tax
        [HttpGet("{taxId}")]
        public IActionResult GetTaxby(uint taxId)
        {
            try
            {
                Tax outputItem = DataAccess.Instance.Tax.Get(taxId);
                if (outputItem == null)
                    return StatusCode(500, "TaxId is not in database");
                else
                    return Ok(outputItem);
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
        
        //Post: api/Tax
        [HttpPost()]
        public IActionResult Post([FromBody] Tax tax)
        {
            try
            {
                return Ok(DataAccess.Instance.Tax.Insert(tax));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        //Put: api/Tax
        [HttpPut()]
        public IActionResult Put([FromBody] Tax tax)
        {
            try
            {
                return Ok(DataAccess.Instance.Tax.Update(tax));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        //Put: api/Tax
        [HttpDelete("{taxId}")]
        public IActionResult Delete(uint taxId)
        {
            try
            {
                if (DataAccess.Instance.Tax.Get(taxId) == null)
                    return Ok("Tax info does not exist in database");
                else
                    DataAccess.Instance.Tax.Delete(taxId);

                return Ok("Tax Id deleted"); 
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
    }
}