using System;
using Microsoft.AspNetCore.Mvc;
using Shared;
using pos_core_api.ORM;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {

        /// <summary>
        /// A get all request that retrieves all the items in the inventory. 
        /// </summary>
        /// <returns>
        /// Returns a list of iventory items. 
        /// </returns>
        // GET: api/Inventory
        [HttpGet]
        public IActionResult Get()
        { 
            try
            {
                return Ok(DataAccess.Instance.Inventory.GetInv());
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
        [HttpGet("id/{id}", Name = "GetInventory")]
        public IActionResult Get(uint id)
        {
            try
            {
                Inventory output = DataAccess.Instance.Inventory.GetInv(id);
                if (output == null)
                    return StatusCode(400, $"The item with the id '{id}' does not exist.");
                else
                    return Ok(output);
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }

        }

        /// <summary>
        /// Returns the hash of the data for the  . 
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns>
        /// A single inventory item that matches the barcode. 
        /// </returns>
        // GET: api/Inventory/barcode
        [HttpGet("Hash", Name = "GetInventoryHash")]
        public IActionResult GetHash()
        {
            try
            {
                return Ok(DataAccess.Instance.Inventory.GetInvHash());
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
        [HttpGet("{barcode}", Name = "GetInventoryBarcode")]
        public IActionResult Get(string barcode)
        {
            try
            {
                Inventory output = DataAccess.Instance.Inventory.GetInv(barcode);

                if (output == null) 
                    return StatusCode(400, $"That item with the barcode '{barcode}' does not exist.");
                else
                    return Ok(output);
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        /// <summary>
        /// Creates a new inventory item and stores it in the inventory description table.
        /// </summary>
        /// <param name="inv"></param>
        /// <returns></returns>
        // POST: api/Inventory
        [HttpPost]
        public IActionResult Post([FromBody] Inventory inv)
        {
            try
            {
                long lastID = -1;

                if (DataAccess.Instance.Inventory.DoesBarcodeExist(inv.Barcode))
                    return StatusCode(400, "Barcode already exist.");

                DataAccess.Instance.Inventory.Insert(inv);
                return StatusCode(201, lastID);
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }


        //Create a post method for adding items to the inventory_price.
        /// <summary>
        /// Udpates and existing item in the inventory_description table.
        /// </summary>
        /// <param name="barcode"></param>
        /// <param name="inv"></param>
        /// <returns></returns>
        // PUT: api/Inventory
        [HttpPut]
        public IActionResult Put([FromBody] Inventory inv)
        {
            try
            {
                if (!DataAccess.Instance.Inventory.DoesBarcodeExist(inv.Barcode))
                    return Post(inv);

                return Ok(DataAccess.Instance.Inventory.Update(inv));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        // DELETE: api/[controller]/id
        [HttpDelete("{Invid}")]
        public IActionResult Delete(uint Invid)
        {
            try
            {
                DataAccess.Instance.Inventory.Delete(Invid);
                return Ok("Item succesfully Deleted.");
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
    }
}

