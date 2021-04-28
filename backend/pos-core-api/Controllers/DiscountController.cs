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
            try
            {
                return Ok(DataAccess.Instance.Discount.Get());
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        // Get: api/Discount
        [HttpGet("{DiscountId}")]
        public IActionResult GetDiscountby(uint DiscountId)
        {
            try
            {
                Discount outputItem = DataAccess.Instance.Discount.Get(DiscountId);
                if (outputItem == null)
                    return StatusCode(500, "DiscountId is not in database");
                else
                    return Ok(outputItem);
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
        
        //Post: api/Discount
        [HttpPost()]
        public IActionResult Post([FromBody] Discount Discount)
        {
            try
            {
                return Ok(DataAccess.Instance.Discount.Insert(Discount));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        //Put: api/Discount
        [HttpPut()]
        public IActionResult Put([FromBody] Discount Discount)
        {
            try
            {
                return Ok(DataAccess.Instance.Discount.Update(Discount));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        //Put: api/Discount
        [HttpPut("{discountId}/{typeId}")]
        public IActionResult Put(uint discountId, int typeId)
        {
            try
            {
                return Ok(DataAccess.Instance.Discount.Update(discountId, typeId));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        //Put: api/Discount
        [HttpDelete("{discountId}/{typeId}")]
        public IActionResult Delete(uint discountId, int typeId)
        {
            try
            {
                DataAccess.Instance.Discount.Delete(discountId, typeId);
                return Ok();
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        //Put: api/Discount
        [HttpDelete("{DiscountId}")]
        public IActionResult Delete(uint DiscountId)
        {
            try
            {
                if (DataAccess.Instance.Discount.Get(DiscountId) == null)
                    return Ok("Discount info does not exist in database");
                else
                    DataAccess.Instance.Discount.Delete(DiscountId);

                return Ok("Discount Id deleted");
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
    }
}