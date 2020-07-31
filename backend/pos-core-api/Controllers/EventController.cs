using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pos_core_api.ORM;
using Shared;
using WebApi.Helpers;

namespace pos_core_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        [HttpGet(Name = "Get Events")]
        public IActionResult Get()
        {
            try
            {
                return Ok(DataAccess.Instance.Event.Get());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("id/{id}", Name = "GetEventId")]
        public IActionResult Get(uint id)
        {
            Event output;

            try
            {
                output = DataAccess.Instance.Event.Get(id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

            if (output == null)
                return StatusCode(400, $"The event id '{id}' does not exist.");
            else
                return Ok(output);
        }

        /// <summary>
        /// Returns a single item that matches the barcode that is sent. 
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns>
        /// A single inventory item that matches the barcode. 
        /// </returns>
        // GET: api/Inventory/barcode
        [HttpGet("{barcode}", Name = "GetEventBarcode")]
        public IActionResult Get(string barcode)
        {
            Event output;

            try
            {
                output = DataAccess.Instance.Event.Get(barcode);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

            if (output == null)
                return StatusCode(400, $"That item with the barcode '{barcode}' does not exist.");
            else
                return Ok(output);
        }
    }

}
