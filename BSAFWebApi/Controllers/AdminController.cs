using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSAFWebApi.Models;
using BSAFWebApi.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using BSAFWebApi.Dtos;

namespace BSAFWebApi.Controllers
{
    public class AdminController : ControllerBase
    {
        private readonly IConfiguration _config;
        private UserManager<User> _userManager = null;
        private SignInManager<User> _signInManager = null;
        DataContext db = null;

        public AdminController(IConfiguration config, UserManager<User> userManager,
        SignInManager<User> signInManager, DataContext context)
        {
            _config = config;
            _userManager = userManager;
            _signInManager = signInManager;
            db = context;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Createuser([FromBody] UserRegistrationDto model)
        {
            var result = await _userManager.CreateAsync(
            new User()
            {
                UserName = model.Username
            }, model.Password
            );
            if (result.Succeeded)
            {
                return Ok();
            }
            return BadRequest(result.Errors.ToString());
        }

    }
}