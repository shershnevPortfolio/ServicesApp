using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using MediatR.Pipeline;
using ServicesApp.Core.DTOs;
using ServicesApp.Core.Exceptions;
using ServicesApp.Core.Abstractions.ExceptionHandlers;
using ServicesApp.Core.Queries;

namespace ServicesApp.Core.ExceptionHandlers
{
    internal class EntityNotFoundExceptionHandler<TRequest, TResponse, TException> : BaseExceptionHandler<TRequest, TResponse, TException> 
        where TException : EntityNotFoundException
       
    {
        public EntityNotFoundExceptionHandler() : base(ResultStatus.NotFound)
        {
        }


    }
}
