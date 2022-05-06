using System;
using Microsoft.AspNetCore.Mvc;
using Shared;
using pos_core_api.ORM;
using System.Collections.Generic;

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
        public IActionResult Get(string barcode = null)
        {

            try
            {
                if(barcode == null)
                    return Ok(DataAccess.Instance.Inventory.GetInv());
                else
                {
                    Inventory output = DataAccess.Instance.Inventory.GetInv(barcode);

                    if (output == null)
                        return BadRequest($"That item with the barcode '{barcode}' does not exist.");
                    else
                        return Ok(output);
                }
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
                    return BadRequest($"The item with the id '{id}' does not exist.");
                else
                    return Ok(output);
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }

        }

        /// <summary>
        /// Returns the hash of the data for the Inventory view. 
        /// </summary>
        /// <returns>
        /// The hash value for the Inventory view
        /// </returns>
        // GET: api/Inventory/Hash
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
       /* [HttpGet()]
        public IActionResult Get(string barcode)
        {
            try
            {
                Inventory output = DataAccess.Instance.Inventory.GetInv(barcode);

                if (output == null) 
                    return BadRequest($"That item with the barcode '{barcode}' does not exist.");
                else
                    return Ok(output);
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
       */
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
                if (DataAccess.Instance.Inventory.DoesBarcodeExist(inv.Barcode))
                    return BadRequest("Barcode already exist.");

                return Ok(DataAccess.Instance.Inventory.Insert(inv));
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
            List<Transaction> suspendedTransactions = DataAccess.Instance.Transaction.GetSuspendedTransactions();

            foreach (Transaction suspendedTransaction in suspendedTransactions) {
                foreach (Item item in suspendedTransaction.Items) {
                    if (item.Id == Invid) { return StatusCode(400, "Inventory item cannot be deleted, it exists in a transaction."); }
                }
            }

            try
            {
                DataAccess.Instance.Inventory.Delete(Invid);
                return Ok("Item succesfully deleted.");
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
    }
}

