using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Shared;
using System.Linq;
using pos_core_api.ORM;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerNoteController : ControllerBase
    {
        // Get: api/CustomerNote
        [HttpGet]
        public IActionResult Get(uint typeID)
        {
            try
            {
                if (typeID > 0)
                    return Ok(DataAccess.Instance.CustomerNote.Get(typeID));
                else
                    return Ok(DataAccess.Instance.CustomerNote.Get());
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET: api/CustomerNote/ID
        [HttpGet("{CustomerID}")]
        public IActionResult Get(uint CustomerID, uint typeID)
        {
            try
            {
                if (typeID > 0)
                    return Ok(DataAccess.Instance.CustomerNote.Get(CustomerID).Where(x=>x.IdNoteType == typeID));
                else
                    return Ok(DataAccess.Instance.CustomerNote.Get(CustomerID));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        // GET: api/CustomerNote/NoteType
        [HttpGet("NoteType/")]
        public IActionResult GetNoteType()
        {
            try
            {
                return Ok(DataAccess.Instance.CustomerNote.GetNoteTypes());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        // POST: api/CustomerNote
        [HttpPost]
        public IActionResult Post([FromBody] CustomerNote custNote)
        {
            try
            {
               return Ok( DataAccess.Instance.CustomerNote.Insert(custNote));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT: api/CustomerNote/{custID}
        [HttpPut]
        public IActionResult Put([FromBody] CustomerNote custNote)
        {
            try
            {
                if (DataAccess.Instance.CustomerNote.Update(custNote) > 0)
                    return Ok();
                else
                    return StatusCode(404);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // Delete: api/CustomerNote/{custID}
        [HttpDelete("{custNoteID}")]
        public IActionResult Delete(uint custNoteID)
        {
            try
            {
                DataAccess.Instance.CustomerNote.Delete(custNoteID);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST: api/CustomerNote
        [HttpPost("NoteType/")]
        public IActionResult PostNoteType([FromBody] NoteType noteType)
        {
            try
            {
                return Ok(DataAccess.Instance.CustomerNote.InsertNoteType(noteType));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT: api/CustomerNote/{custID}
        [HttpPut("NoteType/")]
        public IActionResult PutNoteType([FromBody] NoteType noteType)
        {
            try
            {
                if (DataAccess.Instance.CustomerNote.UpdateNoteType(noteType) > 0)
                    return Ok();
                else
                    return StatusCode(404);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // Delete: api/CustomerNote/NoteType/{noteTypeID}
        [HttpDelete("NoteType/{noteTypeID}")]
        public IActionResult DeleteNoteType(uint noteTypeID)
        {
            try
            {
                DataAccess.Instance.CustomerNote.DeleteNoteType(noteTypeID);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}