using Microsoft.AspNetCore.Mvc;
using Shared;
using pos_core_api.ORM;
using System;

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
            try
            {
                return Ok(DataAccess.Instance.Printer.Get());
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        // Get: api/Printer/make
        [HttpGet("Make")]
        public IActionResult GetPrinterMake()
        {
            try
            {
                return Ok(DataAccess.Instance.Printer.GetMake());
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        // Get: api/Printer/make
        [HttpGet("Make/{makeId}")]
        public IActionResult GetPrinterMake(uint makeId)
        {
            try
            {
                return Ok(DataAccess.Instance.Printer.GetMake(makeId));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        // Get: api/Printer
        [HttpGet("{PrinterId}")]
        public IActionResult GetPrinterby(uint PrinterId)
        {
            try
            {
                Printer outputItem = DataAccess.Instance.Printer.Get(PrinterId);

                if (outputItem == null)
                    return StatusCode(500, "PrinterId is not in database");
                else
                    return Ok(outputItem); 
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
        
        //Post: api/Printer
        [HttpPost()]
        public IActionResult Post([FromBody] Printer Printer)
        {
            try
            {
                return Ok(DataAccess.Instance.Printer.Insert(Printer));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        //Put: api/Printer
        [HttpPut()]
        public IActionResult Put([FromBody] Printer Printer)
        {
            try
            {
                return Ok(DataAccess.Instance.Printer.Update(Printer));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        //Put: api/Printer
        [HttpDelete("{PrinterId}")]
        public IActionResult Delete(uint PrinterId)
        {
            try
            {
                if (DataAccess.Instance.Printer.Get(PrinterId) == null)
                    return Ok("Printer info does not exist in database");
                else
                    DataAccess.Instance.Printer.Delete(PrinterId);

                return Ok("Printer Id deleted");
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
    }
}