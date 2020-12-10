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

        void CreateResult();

    }

    interface ICommandHandlerService<TEntity> : IHandlerService<TEntity> where TEntity : BaseEntity 
    {
        TEntity MapToDomain(CrudCommand command);
    }


    interface IQueryHandlerService<TEntity> : IHandlerService<TEntity> where TEntity : BaseEntity
    {
        TEntity MapQueryFilterDomain(CrudCommand command);
    }
}
