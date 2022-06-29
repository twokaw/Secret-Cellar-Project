using Microsoft.AspNetCore.Mvc;
using pos_core_api.ORM;
using Shared;
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

        [HttpPost()]
        public IActionResult PostType([FromBody] EmployeeTypeModel empType)
        {
            try
            {
                return Ok(DataAccess.Instance.EmployeeType.Insert(empType));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut()]
        public IActionResult PutType([FromBody] EmployeeTypeModel empType)
        {
            try
            {
                return Ok(DataAccess.Instance.EmployeeType.Update(empType));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        
        }

        [HttpPost("role")]
        public IActionResult PostRole([FromBody] EmployeeRoleModel role)
        {
            try
            {
                return Ok(DataAccess.Instance.EmployeeType.InsertRole(role));
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("role")]
        public IActionResult PutRole([FromBody] EmployeeRoleModel role)
        {
            try
            {
                return Ok(DataAccess.Instance.EmployeeType.UpdateRole(role));
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
