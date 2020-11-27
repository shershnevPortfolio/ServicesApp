﻿using Ardalis.Result;
using Microsoft.AspNetCore.Identity;
using ServicesApp.Core.Commands;
using ServicesApp.Core.DTOs;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Interfaces
{
    public interface IAuthenticationService
    {
        Task<Result<IdentityResult>> RegisterUser(RegisterCommand registerData);

        Task<Result<UserDTO>> Login(LoginCommand loginData);
    }
}
