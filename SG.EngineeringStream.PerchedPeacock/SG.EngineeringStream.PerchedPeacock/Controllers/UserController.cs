using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SG.EngineeringStream.PerchedPeacock.Models;
using SG.EngineeringStream.PerchedPeacock.Service;
using SG.EngineeringStream.PerchedPeacock.Service.Interfaces;

namespace SG.EngineeringStream.PerchedPeacock.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: api/User
        [HttpGet]
        public OkObjectResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPost("register", Name = "Register")]
        public OkObjectResult Register([FromBody] User user)
        {
            return Ok(_userService.RegisterUser(user,Startup.ConnectionString));
        }

        [HttpPost("signIn", Name = "SignIn")]
        public OkObjectResult SignIn([FromBody] User user)
        {
            return Ok(_userService.SignIn(user, Startup.ConnectionString));
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
