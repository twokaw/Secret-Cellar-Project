using Microsoft.AspNetCore.Mvc;
using Shared;
using pos_core_api.ORM;
using System;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        // Get: api/Discount
        [HttpGet]
        public IActionResult GetDiscount()
        {
            return Ok(DataAccess.Instance.Discount.Get());
        }

        // Get: api/Discount
        [HttpGet("{DiscountId}")]
        public IActionResult GetDiscountby(uint DiscountId)
        {
            Discount outputItem = DataAccess.Instance.Discount.Get(DiscountId);
            if (outputItem == null)
                return StatusCode(500, "DiscountId is not in database");
            else
                return Ok(outputItem);
        }
        
        //Post: api/Discount
        [HttpPost()]
        public IActionResult Post([FromBody] Discount Discount)
        {
            return Ok(DataAccess.Instance.Discount.Insert(Discount));
        }

        //Put: api/Discount
        [HttpPut()]
        public IActionResult Put([FromBody] Discount Discount)
        {
            return Ok(DataAccess.Instance.Discount.Update(Discount));
        }

        //Put: api/Discount
        [HttpPut("{discountId}/{typeId}")]
        public IActionResult Put(uint discountId, int typeId)
        {
            return Ok(DataAccess.Instance.Discount.Update(discountId, typeId));
        }

        //Put: api/Discount
        [HttpDelete("{discountId}/{typeId}")]
        public IActionResult Delete(uint discountId, int typeId)
        {
            try
            {
                DataAccess.Instance.Discount.Delete(discountId, typeId);
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Delete failed: {ex.Message}");
            }
            return Ok();
        }

        //Put: api/Discount
        [HttpDelete("{DiscountId}")]
        public IActionResult Delete(uint DiscountId)
        {
            if (DataAccess.Instance.Discount.Get(DiscountId) == null)
                return Ok("Discount info does not exist in database");
            else
                DataAccess.Instance.Discount.Delete(DiscountId);

            return Ok("Discount Id deleted");
        }
    }
}