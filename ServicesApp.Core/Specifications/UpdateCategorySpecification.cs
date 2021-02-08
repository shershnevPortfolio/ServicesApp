using ServicesApp.Core.Abstractions.Specifications.UpdateSpecifications;
using ServicesApp.Core.Commands;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Specifications
{
    class UpdateCategorySpecification : UpdateSpecification<Category>
    {
        public UpdateCategorySpecification(UpdateCategoryCommand command)
        {
            _updateActions.Add(x => x.Name = command.Name);
        }
    }
}
