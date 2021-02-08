using ServicesApp.Core.Abstractions.Specifications.UpdateSpecifications;
using ServicesApp.Core.Commands;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Specifications
{
    class UpdateSubcategorySpecification : UpdateSpecification<Subcategory>
    {
        public UpdateSubcategorySpecification(UpdateSubcategoryCommand command)
        {
            _updateActions.Add(x => x.Name = command.Name);
        }
    }
}
