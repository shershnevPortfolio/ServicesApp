using AutoMapper;
using Microsoft.AspNetCore.Identity;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Commands;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.CommandHandlers
{
    internal class RegisterCommandHandler : ICommandHandler<RegisterCommand>
    {
        private readonly UserManager<User> _userManager;

        private readonly IMapper _mapper;

        public RegisterCommandHandler(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }
        public async Task Handle(RegisterCommand command)
        {
            var user = _mapper.Map<User>(command);
            var result = await _userManager.CreateAsync(user, command.Password);
            command.Result = result;
        }
    }
}
