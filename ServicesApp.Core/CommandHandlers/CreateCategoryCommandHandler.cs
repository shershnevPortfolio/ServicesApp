using ServicesApp.Core.Abstractions.CommandHandlers;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Commands;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.CommandHandlers
{
    internal class CreateCategoryCommandHandler : CreateCommandHandler<CreateCategoryCommand, Category>
    {
        public CreateCategoryCommandHandler(IUnitOfWork unitOfWork, ICommandVisitor visiter, ICommandHandlerService<Category> commandHandlerService) 
            : base(unitOfWork, visiter, commandHandlerService)
        {

        }

    }
}
