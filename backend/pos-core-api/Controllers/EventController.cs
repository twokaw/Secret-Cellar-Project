using System;
using Microsoft.AspNetCore.Mvc;
using pos_core_api.ORM;
using Shared;

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
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        [HttpGet("id/{id}", Name = "GetEventId")]
        public IActionResult Get(uint id)
        {
            try
            {
                Event output = DataAccess.Instance.Event.Get(id);

                if (output == null)
                    return BadRequest($"The event id '{id}' does not exist.");
                else
                    return Ok(output);
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }

        }

        /// <summary>
        /// Returns a single item that matches the barcode that is sent. 
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns>
        /// A single inventory item that matches the barcode. 
        /// </returns>
        // GET: api/Inventory/barcode
        [HttpGet()]
        public IActionResult Get(string barcode)
        {
            Event output;

            try
            {
                output = DataAccess.Instance.Event.Get(barcode);
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }

            if (output == null)
                return BadRequest($"That item with the barcode '{barcode}' does not exist.");
            else
                return Ok(output);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Event evt)
        {
            try 
            {
                return Ok(DataAccess.Instance.Event.Insert(evt));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Event evt)
        {
            try
            {
                return Ok(DataAccess.Instance.Event.Update(evt));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(uint id)
        {
            try
            {
                DataAccess.Instance.Event.Delete(id);
                return Ok();
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        [HttpGet("Waitlists")]
        public IActionResult GetWaitlists() {
            try {
                return Ok(DataAccess.Instance.Event.GetEventsWaitlists());
            } catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        [HttpPost("Waitlists")]
        public IActionResult Post([FromBody] EventWaitlistItem eventWaitlistItem) {
            try {
                return Ok(DataAccess.Instance.Event.AddEventWaitlistItem(eventWaitlistItem));
            } catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        [HttpDelete("Waitlists/Delete/eventId={eventId}&customerId={customerId}")]
        public IActionResult DeleteWaitlistItem(uint eventId, uint customerId) {
            try {
                DataAccess.Instance.Event.DeleteEventWaitlistItem(eventId, customerId);
                return Ok();
            } catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        [HttpGet("PreviousEventData")]
        public IActionResult GetPreviousEventData() {
            try {
                return Ok(DataAccess.Instance.Event.GetPreviousEventData());
            } catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        [HttpGet("PreviousEventData/{eventId}")]
        public IActionResult GetPreviousEventData(uint eventId) {
            try {
                return Ok(DataAccess.Instance.Event.GetPreviousEventData(eventId));
            } catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
    }
}
