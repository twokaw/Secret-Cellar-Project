using Microsoft.AspNetCore.Mvc;
using pos_core_api.ORM;
using System;

namespace pos_core_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeTypeController : Controller
    {
        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                return Ok(DataAccess.Instance.EmployeeType.Get());
            }

            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("role")]
        public IActionResult GetRole()
        {
            try
            {
                return Ok(DataAccess.Instance.EmployeeType.GetRoles());
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
