using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApi.Helpers;
using MySql.Data.MySqlClient;
using System.Data;
using Shared;
using System.Linq;
using pos_core_api.ORM;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryTypeController : ControllerBase
    {
        /// <summary>
        /// Get call that returns all the item types that are stored in the database.
        /// </summary>
        /// <returns>list of type objects.</returns>
        // GET: api/InventoryType
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(DataAccess.Instance.InventoryType.Get());
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }


        /// <summary>
        /// Get call that returns one item type specified by the type name. 
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns>An object of the requested type.</returns>
        // GET: api/InventoryType/typeName
        [HttpGet("{typeId}", Name = "GetTypeById")]
        public IActionResult GetID(uint typeId)
        {
            try
            {
                InventoryType it = DataAccess.Instance.InventoryType.Get(typeId);
                if (it != null)
                    return Ok(it);
                else
                    return NotFound($"{typeId} not found");
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }


        /// <summary>
        /// Get call that returns one item type specified by the type name. 
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns>An object of the requested type.</returns>
        // GET: api/InventoryType/typeName
        [HttpGet("Name")]
        public IActionResult GetName(string name)
        {
            try
            {
                InventoryType it = DataAccess.Instance.InventoryType.Get(name);
                if (it != null)
                    return Ok(it);
                else
                    return NotFound($"{name} not found");
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="invType"></param>
        /// <returns></returns>
        // POST: api/InventoryType
        [HttpPost]
        public IActionResult Post([FromBody] InventoryType invType)
        {
            try
            {
                if (DataAccess.Instance.InventoryType.GetTypeQty(false, 0, invType.TypeName) > -1) 
                    return BadRequest("Type already exist.");

                return StatusCode(201, DataAccess.Instance.InventoryType.Insert(invType));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }


        // PUT: api/InventoryType
        [HttpPut()]
        public IActionResult Put([FromBody] InventoryType invType)
        {
            try
            {
                uint newId;

                // if id and name doesn't exist then call the post
                if (DataAccess.Instance.InventoryType.GetTypeQty(true, invType.TypeId, invType.TypeName) == -1)
                    newId = DataAccess.Instance.InventoryType.Insert(invType);
                else
                {
                    DataAccess.Instance.InventoryType.Update(invType);
                    newId = invType.TypeId;
                }

                return Ok(newId);
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }


        // DELETE: api/InventoryType/Delete/5
        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(uint id)
        {
            try
            {
                int qty = DataAccess.Instance.InventoryType.GetTypeQty(true, id, "");

                if(qty == -1)
                    return BadRequest($"No type with the id '{id}'.");
                else if (qty > 0)
                    return BadRequest($"Can't delete Type id '{id}'.  It has {qty} inventory items assigned to it");

                DataAccess.Instance.InventoryType.Delete(id);
                return Ok("Type succesfully Deleted");
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
    }
}
