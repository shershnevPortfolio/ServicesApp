using Ardalis.Result;
using AutoMapper;
using ServicesApp.Core.Abstractions.Commands;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Commands;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Infrastructure.Visiters
{
    class CommandQueryVisiter : ICommandVisitor
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public CommandQueryVisiter(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Visit<TEntity>(GetCommand<TEntity> command) where TEntity : BaseEntity
        {
            var repository = GetRepository<TEntity>();
            command.Result = Result<object>.Success(await repository.GetById(command.Id));
        }

        public async Task Visit<TEntity>(GetEnumerableCommand<TEntity> command) where TEntity : BaseEntity
        {
            var repo = GetRepository<TEntity>();
            command.Result = Result<object>.Success(repo.GetAll());
        }

        public async Task Visit<TEntity>(CreateCommand<TEntity> command) where TEntity : BaseEntity
        {
            var repo = GetRepository<TEntity>();
            await repo.Add(_mapper.Map<TEntity>(command));
            command.Result = Result<object>.Success(true);
        }

        private IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity
        {
            return _unitOfWork.GetRepository<TEntity>();
        }
    }
}
