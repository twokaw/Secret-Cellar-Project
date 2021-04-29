using System;
using Microsoft.AspNetCore.Mvc;
using Shared;
using pos_core_api.ORM;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        // Get: api/employee
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(DataAccess.Instance.Employee.Get());
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET: api/Employee/ID
        [HttpGet("{employeeID}")]
        public IActionResult Get(String employeeID)
        {
            try
            {
                return Ok(DataAccess.Instance.Employee.Get(employeeID));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        // POST: api/Employee
        [HttpPost]
        public IActionResult Post([FromBody] EmployeeModel emp)
        {
            try
            {
                return Ok(DataAccess.Instance.Employee.Insert(emp));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        // PUT: api/Employee/{EmpID}
        [HttpPut]
        public IActionResult Put([FromBody] EmployeeModel emp)
        {
            try
            {
                DataAccess.Instance.Employee.Update(emp);
                return Ok();
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        // Delete: api/Employee/{EmpID}
        [HttpDelete("{empID}")]
        public IActionResult Delete(uint empID)
        {
            try
            {
                DataAccess.Instance.Employee.Delete(empID);
                return Ok();
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
    }
}