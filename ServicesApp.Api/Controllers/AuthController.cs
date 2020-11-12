﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ServicesApp.Core.Entities;
using AutoMapper;
using ServicesApp.Core.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServicesApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private UserManager<User> _userManager;
        private IMapper _mapper;

        public AuthController(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;

        }

        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> Register([FromQuery] RegisterDTO registerData)
        {
            var user = _mapper.Map<User>(registerData);
            var result = await _userManager.CreateAsync(user, registerData.Password);
            if (result.Succeeded)
            {
                return Ok(result);
            }

            return BadRequest(result.Errors);
        }


        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login([FromQuery] LoginDTO loginData)
        {
            var user = await _userManager.FindByNameAsync(loginData.UserName);
            if(user != null && await _userManager.CheckPasswordAsync(user, loginData.Password))
            {
                var token = await _userManager.CreateSecurityTokenAsync(user);
                return Ok(new { token = token, user = _mapper.Map<UserDTO>(user) }); ;
            }
            else
            {
                return BadRequest(new { message = "inncorrect login data" } );
            }
        }

    }
}
