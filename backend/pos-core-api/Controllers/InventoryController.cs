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
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
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
            Inventory output;
            try
            {
                output = DataAccess.Instance.Inventory.GetInv(id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

            if (output == null)
                return StatusCode(400, $"The item with the id '{id}' does not exist.");
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
        [HttpGet("{barcode}", Name = "GetInventoryBarcode")]
        public IActionResult Get(string barcode)
        {
            Inventory output;

            try
            {
                output = DataAccess.Instance.Inventory.GetInv(barcode);
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

        /// <summary>
        /// Creates a new inventory item and stores it in the inventory description table.
        /// </summary>
        /// <param name="inv"></param>
        /// <returns></returns>
        // POST: api/Inventory
        [HttpPost]
        public IActionResult Post([FromBody] Inventory inv)
        {
            long lastID = -1;

            if (DataAccess.Instance.Inventory.DoesBarcodeExist(inv.Barcode))
                return StatusCode(400, "Barcode already exist.");

            try
            {
                DataAccess.Instance.Inventory.Insert(inv);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

            return StatusCode(201, lastID);
        }


        //Create a post method for adding items to the inventory_price.
        /// <summary>
        /// Udpates and existing item in the inventory_description table.
        /// </summary>
        /// <param name="barcode"></param>
        /// <param name="inv"></param>
        /// <returns></returns>
        // PUT: api/Inventory/barcode
        [HttpPut("{barcode}", Name = "PutDescription")]
        public IActionResult Put([FromBody] Inventory inv)
        {
            long lastID = -1;

            if (!DataAccess.Instance.Inventory.DoesBarcodeExist(inv.Barcode))
                return Post(inv);

            try
            {
                DataAccess.Instance.Inventory.Update(inv);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

            return Ok(lastID);
        }

        // DELETE: api/[controller]/id
        [HttpDelete("{Invid}")]
        public IActionResult Delete(int Invid)
        {
            try
            {
                DataAccess.Instance.Inventory.Delete(Invid);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

            return Ok("Item succesfully Deleted.");
        }
    }
}

