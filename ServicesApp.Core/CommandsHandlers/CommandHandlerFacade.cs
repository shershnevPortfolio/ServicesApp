﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ServicesApp.Core.Commands;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Abstractions.Commands;

namespace ServicesApp.Core.CommandsHandlers
{
    public class CommandHandlerFacade: ICommandHandler
    {
        private readonly IServiceProvider _serviceProvider;

        private readonly ICommandHandlerFactory _commandHandlerFactory;

        private readonly IUnitOfWork _unitOfWork;

        public CommandHandlerFacade(IServiceProvider serviceProvider, IUnitOfWork unitOfWork)
        {
            _serviceProvider = serviceProvider;
            _commandHandlerFactory = _serviceProvider.GetService<ICommandHandlerFactory>();
            _unitOfWork = unitOfWork;
        }



        public async Task Handle<TCommand>(TCommand command) where TCommand : BaseCommand
        {
            var handler = _commandHandlerFactory.CreateHandlerFor<TCommand>();
            await handler.Handle(command);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
