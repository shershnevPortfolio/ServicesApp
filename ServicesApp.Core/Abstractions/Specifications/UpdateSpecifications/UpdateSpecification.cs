using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Collections.ObjectModel;
using ServicesApp.Core.Abstractions.Commands;

namespace ServicesApp.Core.Abstractions.Specifications.UpdateSpecifications
{
    public abstract class UpdateSpecification<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly List<Action<TEntity>> _updateActions =  new List<Action<TEntity>>();

        public UpdateSpecification()
        { 
        }


        public void Apply(TEntity entity) 
        {
            foreach (var action in _updateActions) 
            {
                action.Invoke(entity);
            }
        }


    }

}
