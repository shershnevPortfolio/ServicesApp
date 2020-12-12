using System;
using System.Collections.Generic;
using System.Text;
using ServicesApp.Core.Abstractions.CommandHandlers;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Queries;
using ServicesApp.Core.Entities;
using ServicesApp.Core.Commands;

namespace ServicesApp.Core.CommandHandlers
{
    internal class CreateOrderCommandHandler : CreateCommandHandler<CreateOrderCommand, Order>
    {
        public CreateOrderCommandHandler(IUnitOfWork unitOfWork, ICommandHandlerService<Order> commandHandlerService) 
            : base(unitOfWork, commandHandlerService)
        {
        }
    }
}
