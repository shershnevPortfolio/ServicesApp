using ServicesApp.Core.Abstractions.CommandHandlers;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Queries;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ServicesApp.Core.Commands;

namespace ServicesApp.Core.CommandHandlers
{
    internal class CreateSubcategoryCommandHandler : CreateCommandHandler<CreateSubcategoryCommand, Subcategory>
    {
        public CreateSubcategoryCommandHandler(IUnitOfWork unitOfWork, ICommandHandlerService<Subcategory> commandHandlerService) 
            : base(unitOfWork,  commandHandlerService)
        {
        }
    }
}
