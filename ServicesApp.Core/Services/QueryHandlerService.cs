using Ardalis.Result;
using AutoMapper;
using ServicesApp.Core.Abstractions.Commands;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Services
{
    internal class QueryHandlerService<TEntity> : IQueryHandlerService<TEntity> where TEntity : BaseEntity
    {
        private readonly IUnitOfWork _unitOfWork;

        public IRepository<TEntity> Repository { get; }

        private readonly IMapper _mapper;

        public QueryHandlerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            Repository = _unitOfWork.GetRepository<TEntity>();
        }

        

        public void CancelOperation()
        {
            throw new NotImplementedException();
        }

     
        public object MapQueryFilter(CrudCommand command)
        {
            throw new NotImplementedException();
        }

        public Result<TResult> CreateResult<TResult>(TEntity entity)
        {
            return Result<TResult>.Success(_mapper.Map<TResult>(entity));
        }
    }
}
