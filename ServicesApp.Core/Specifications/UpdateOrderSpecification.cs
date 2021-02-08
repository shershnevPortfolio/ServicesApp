using System;
using System.Collections.Generic;
using System.Text;
using ServicesApp.Core.Abstractions.Specifications.UpdateSpecifications;
using ServicesApp.Core.Entities;
using ServicesApp.Core.Commands;
using System.Linq.Expressions;

namespace ServicesApp.Core.Specifications
{
    public class UpdateOrderSpecification : UpdateSpecification<Order>
    {
        public UpdateOrderSpecification(UpdateOrderCommand command) : base()
        {
            _updateActions.Add(entity => entity.Budjet = command.Budjet);
            _updateActions.Add(entity => entity.Header = command.Header);
            _updateActions.Add(entity => entity.Explanation = command.Explanation);
            _updateActions.Add(entity => entity.Budjet = command.Budjet);
        }
    }

}
