using Microsoft.AspNetCore.Mvc;
using Shared;
using pos_core_api.ORM;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrinterController : ControllerBase
    {
        // Get: api/Printer
        [HttpGet]
        public IActionResult GetPrinter()
        {
            return Ok(DataAccess.Instance.Printer.Get());
        }

        // Get: api/Printer/make
        [HttpGet("Make")]
        public IActionResult GetPrinterMake()
        {
            return Ok(DataAccess.Instance.Printer.GetMake());
        }

        // Get: api/Printer/make
        [HttpGet("Make/{makeId}")]
        public IActionResult GetPrinterMake(uint makeId)
        {
            return Ok(DataAccess.Instance.Printer.GetMake(makeId));
        }

        // Get: api/Printer
        [HttpGet("{PrinterId}")]
        public IActionResult GetPrinterby(uint PrinterId)
        {
            Printer outputItem = DataAccess.Instance.Printer.Get(PrinterId);
            if (outputItem == null)
                return StatusCode(500, "PrinterId is not in database");
            else
                return Ok(outputItem);
        }
        
        //Post: api/Printer
        [HttpPost()]
        public IActionResult Post([FromBody] Printer Printer)
        {
            return Ok(DataAccess.Instance.Printer.Insert(Printer));
        }

        //Put: api/Printer
        [HttpPut()]
        public IActionResult Put([FromBody] Printer Printer)
        {
            return Ok(DataAccess.Instance.Printer.Update(Printer));
        }

        //Put: api/Printer
        [HttpDelete("{PrinterId}")]
        public IActionResult Delete(uint PrinterId)
        {
            if (DataAccess.Instance.Printer.Get(PrinterId) == null)
                return Ok("Printer info does not exist in database");
            else
                DataAccess.Instance.Printer.Delete(PrinterId);

            return Ok("Printer Id deleted");
        }

    }
}