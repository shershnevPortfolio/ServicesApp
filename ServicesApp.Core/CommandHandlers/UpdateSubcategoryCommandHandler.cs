using ServicesApp.Core.Abstractions.CommandHandlers;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Abstractions.Specifications.UpdateSpecifications;
using ServicesApp.Core.Commands;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.CommandHandlers
{
    class UpdateSubcategoryCommandHandler : UpdateCommandHandler<UpdateSubcategoryCommand, Subcategory>
    {
        public UpdateSubcategoryCommandHandler(IUnitOfWork unitOfWork, ICommandHandlerService<Subcategory> handlerService) : base(unitOfWork, handlerService)
        {
        }

        protected override UpdateSpecification<Subcategory> GetSpecification(UpdateSubcategoryCommand request)
        {
            new UpdateSubcategorySpecification(request);
        }
    }
}
