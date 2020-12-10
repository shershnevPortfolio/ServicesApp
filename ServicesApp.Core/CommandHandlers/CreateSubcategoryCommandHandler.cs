using ServicesApp.Core.Abstractions.CommandHandlers;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Commands;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.CommandHandlers
{
    internal class CreateSubcategoryCommandHandler : CreateCommandHandler<CreateSubcategoryCommand, Subcategory>
    {
        public CreateSubcategoryCommandHandler(IUnitOfWork unitOfWork, ICommandVisitor visiter, ICommandHandlerService<Subcategory> commandHandlerService) 
            : base(unitOfWork, visiter, commandHandlerService)
        {
        }
    }
}
