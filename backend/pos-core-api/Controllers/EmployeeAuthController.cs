using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebApi.Services;
using Shared;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeAuthController : ControllerBase
    {
        private IUserService _userService;

        public EmployeeAuthController(IUserService userService)
        {
            _userService = userService;
        }

        //Employee authentication - check if userID and pin are correct. If so return emp_id, pin_number = 0 & admin status
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateModel model)
        {            
            var user = _userService.Authenticate(model.EmployeeID, model.Pin);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }
    }
}