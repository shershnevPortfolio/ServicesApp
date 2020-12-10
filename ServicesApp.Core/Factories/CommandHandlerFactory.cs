using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Linq;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Abstractions.Queries;

namespace ServicesApp.Core.Factories
{
    internal class CommandHandlerFactory : ICommandHandlerFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public CommandHandlerFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public ICommandHandler<TCommand> CreateHandlerFor<TCommand>() where TCommand : BaseCommand
        {
            return _serviceProvider.GetService<ICommandHandler<TCommand>>();
        }

        public IQueryHandler<TQuery, TResult> CreateHandlerFor<TQuery, TResult>() where TQuery : BaseQuery<TResult>
        {
            return _serviceProvider.GetService<IQueryHandler<TQuery, TResult>>();
        }
    }

}
