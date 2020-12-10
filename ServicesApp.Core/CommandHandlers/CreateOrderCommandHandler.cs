using System;
using System.Collections.Generic;
using System.Text;
using ServicesApp.Core.Abstractions.CommandHandlers;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Commands;
using ServicesApp.Core.Entities;

namespace ServicesApp.Core.CommandHandlers
{
    internal class CreateOrderCommandHandler : CreateCommandHandler<CreateOrderCommand, Order>
    {
        public CreateOrderCommandHandler(IUnitOfWork unitOfWork, ICommandVisitor visiter, ICommandHandlerService<Order> commandHandlerService) 
            : base(unitOfWork, visiter, commandHandlerService)
        {
        }
    }
}
