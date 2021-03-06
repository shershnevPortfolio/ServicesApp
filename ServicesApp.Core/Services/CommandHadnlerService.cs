﻿using AutoMapper;
using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ServicesApp.Core.Abstractions.Commands;

namespace ServicesApp.Core.Services
{
    internal class CommandHadnlerService<TEntity> : ICommandHandlerService<TEntity> where TEntity : BaseEntity
    {
        public IRepository<TEntity> Repository { get; }

        private readonly IMapper _mapper;

        public CommandHadnlerService(IUnitOfWork _unitOfWork, IMapper mapper)
        {
            Repository = _unitOfWork.GetRepository<TEntity>();
            _mapper = mapper;

        }

       
        public virtual void CancelOperation()
        {
            throw new NotImplementedException();
        }

        public virtual TEntity MapToDomain(CrudCommand command)
        {
            return _mapper.Map<TEntity>(command);
        }

        public virtual void CreateResult()
        {
            throw new NotImplementedException();
        }
    }
}
