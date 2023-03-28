using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetPatrickUdemy.Dtos.User;
using Microsoft.AspNetCore.Mvc;

namespace DotnetPatrickUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authrepo;

        public AuthController(IAuthRepository authrepo)
        {
            _authrepo = authrepo;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authrepo.Register(
                new User { Username = request.Username }, request.Password

            );
            if(!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<ServiceResponse<int>>> Login(UserLoginDto request)
        {
            var response = await _authrepo.Login(request.Username, request.Password);
            if(!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        
    }
}