using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class ValidateTokenController : ControllerBase
    {
        private readonly IUserService _userService;

        public ValidateTokenController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public bool IsTokenValid(string token)
        {
            bool status = _userService.IsTokenValid(token);

            return status;
        }
    }
}