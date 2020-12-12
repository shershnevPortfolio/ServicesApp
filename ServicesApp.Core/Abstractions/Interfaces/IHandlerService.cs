using Ardalis.Result;
using ServicesApp.Core.Abstractions.Commands;
using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Abstractions.Interfaces
{
    interface IHandlerService<TEntity> where TEntity : BaseEntity
    {
        IRepository<TEntity> Repository { get; }

        void CancelOperation();

    }

    internal interface ICommandHandlerService<TEntity> : IHandlerService<TEntity> where TEntity : BaseEntity 
    {
        TEntity MapToDomain(CrudCommand command);
    }


    internal interface IQueryHandlerService<TEntity> : IHandlerService<TEntity> where TEntity : BaseEntity
    {
        object MapQueryFilter(CrudCommand crudCommand);

        Result<TResult> CreateResult<TResult>(TEntity entity);
    }
}
