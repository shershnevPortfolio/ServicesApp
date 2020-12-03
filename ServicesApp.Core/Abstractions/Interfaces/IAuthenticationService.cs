using Ardalis.Result;
using Microsoft.AspNetCore.Identity;
using ServicesApp.Core.Commands;
using ServicesApp.Core.DTOs;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Abstractions.Interfaces
{
    internal interface IAuthenticationService
    {
        Task RegisterUser(RegisterCommand registerData);

        Task Login(LoginCommand loginData);
    }
}
