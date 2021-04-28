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
        public IActionResult GetID(int typeId)
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
        [HttpGet("Name/{typeName}", Name = "GetTypeByName")]
        public IActionResult GetName(string typeName)
        {
            try
            {
                InventoryType it = DataAccess.Instance.InventoryType.Get(typeName);
                if (it != null)
                    return Ok(it);
                else
                    return NotFound($"{typeName} not found");
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
                if (DataAccess.Instance.InventoryType.GetTypeQty(-1, invType.TypeName) > -1) 
                    return StatusCode(400, "Type already exist.");

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
                if (DataAccess.Instance.InventoryType.GetTypeQty(Convert.ToInt32(invType.TypeId), invType.TypeName) == -1)
                    newId = DataAccess.Instance.InventoryType.Insert(invType);
                else
                {
                    DataAccess.Instance.InventoryType.Update(invType);
                    newId = invType.TypeId;
                }

                return Ok($"{newId}");
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                int qty = DataAccess.Instance.InventoryType.GetTypeQty(id, "");

                if(qty == -1)
                    return StatusCode(400, $"No type with the id '{id}'.");
                else if (qty > 0)
                    return StatusCode(400, $"Can't delete Type id '{id}'.  It has {qty} inventory items assigned to it");

                DataAccess.Instance.InventoryType.Delete(id);
                return Ok("Type succesfully Deleted");
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
    }
}
