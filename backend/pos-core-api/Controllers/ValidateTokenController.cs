using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebApi.Services;
using WebApi.Helpers;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace WebApi.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class ValidateTokenController : ControllerBase
    {
        private IUserService _userService;
        private readonly AppSettings _appSettings;

        public ValidateTokenController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public bool isTokenValid(string token)
        {
            bool status = _userService.isTokenValid(token);

            return status;
        }

    }
}