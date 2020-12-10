using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Commands;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Abstractions.Interfaces
{
    public interface ICommandVisitor
    { 
        Task Visit<TEntity>(GetCommand<TEntity> command) where TEntity : BaseEntity;

        Task Visit<TEntity>(GetEnumerableCommand<TEntity> command) where TEntity : BaseEntity;

        Task Visit<TEntity>(CreateCommand<TEntity> command) where TEntity : BaseEntity;

    }
}
