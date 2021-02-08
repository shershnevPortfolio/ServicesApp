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
    class UpdateCategoryCommandHandler : UpdateCommandHandler<UpdateCategoryCommand, Category>
    {
        public UpdateCategoryCommandHandler(IUnitOfWork unitOfWork, ICommandHandlerService<Category> handlerService) : base(unitOfWork, handlerService)
        {
        }

        protected override UpdateSpecification<Category> GetSpecification(UpdateCategoryCommand request)
        {
            return new UpdateCategorySpecification(request);
        }
    }
}
