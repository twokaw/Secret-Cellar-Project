using Microsoft.AspNetCore.Mvc;
using Shared;
using pos_core_api.ORM;
using System;
using System.Collections.Generic;



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

        //Delete: api/Tax
        [HttpDelete("Delete/{taxId}")]
        public IActionResult Delete(uint taxId)
        {
            List<Inventory> inventories = DataAccess.Instance.Inventory.GetInv();
            inventories = inventories.FindAll((inventory) => inventory.IdTax == taxId);

            if (inventories.Count > 0) { return StatusCode(400, "Tax cannot be deleted, it has items that use it."); }

            try
            {
                if (DataAccess.Instance.Tax.Get(taxId) == null)
                    return StatusCode(400, "Tax info does not exist in the database.");
                else
                    DataAccess.Instance.Tax.Delete(taxId);

                return StatusCode(200, "Tax deleted."); 
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
    }
}