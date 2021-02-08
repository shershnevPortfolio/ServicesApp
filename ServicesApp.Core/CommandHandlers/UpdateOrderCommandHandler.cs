using ServicesApp.Core.Abstractions.CommandHandlers;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Abstractions.Specifications.UpdateSpecifications;
using ServicesApp.Core.Commands;
using ServicesApp.Core.Entities;
using ServicesApp.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.CommandHandlers
{
    class UpdateOrderCommandHandler : UpdateCommandHandler<UpdateOrderCommand, Order>
    {
        public UpdateOrderCommandHandler(IUnitOfWork unitOfWork, ICommandHandlerService<Order> handlerService) : base(unitOfWork, handlerService)
        {
        }

        protected override UpdateSpecification<Order> GetSpecification(UpdateOrderCommand request)
        {
            return new UpdateOrderSpecification(request);
        }
    }
}
