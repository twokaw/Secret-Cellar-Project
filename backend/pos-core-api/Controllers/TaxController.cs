using Microsoft.AspNetCore.Mvc;
using Shared;
using pos_core_api.ORM;

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
            Tax outputItem = DataAccess.Instance.Tax.Get(taxId);
            if (outputItem == null)
                return StatusCode(500, "TaxId is not in database");
            else
                return Ok(outputItem);
        }
        
        //Post: api/Tax
        [HttpPost()]
        public IActionResult Post([FromBody] Tax tax)
        {
            return Ok(DataAccess.Instance.Tax.Insert(tax));
        }

        //Put: api/Tax
        [HttpPut()]
        public IActionResult Put([FromBody] Tax tax)
        {
            return Ok(DataAccess.Instance.Tax.Update(tax));
        }

        //Put: api/Tax
        [HttpDelete("{taxId}")]
        public IActionResult Delete(uint taxId)
        {
            if (DataAccess.Instance.Tax.Get(taxId) == null)
                return Ok("Tax info does not exist in database");
            else
                DataAccess.Instance.Tax.Delete(taxId);

            return Ok("Tax Id deleted");
        }

    }
}