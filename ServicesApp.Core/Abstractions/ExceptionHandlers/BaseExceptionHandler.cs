using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using MediatR.Pipeline;
using System.Collections.ObjectModel;

namespace ServicesApp.Core.Abstractions.ExceptionHandlers
{
    abstract internal class BaseExceptionHandler<TRequest, TResponse, TException> : IRequestExceptionHandler<TRequest, TResponse, TException> where TException : Exception
    {
        protected readonly ResultStatus _resultStatus; 

        protected ReadOnlyDictionary<ResultStatus, string> resultStatusStringValues = new ReadOnlyDictionary<ResultStatus, string>(new Dictionary<ResultStatus, string> { 
            {ResultStatus.NotFound, "NotFound"}, 
            {ResultStatus.Forbidden, "Forbiden"}, 
            {ResultStatus.Invalid, "Invalid"}, 
            {ResultStatus.Error, "Error"}}
        );

        public BaseExceptionHandler(ResultStatus resultStatus)
        {
            _resultStatus = resultStatus;
        }

        public async virtual Task Handle(TRequest request, TException exception, RequestExceptionHandlerState<TResponse> state, CancellationToken cancellationToken) 
        {
            var result = CreateResult(_resultStatus);
            await Task.Run(() => state.SetHandled(result));
        }

        protected virtual TResponse CreateResult(ResultStatus status) 
        {
            var methodName = String.Empty;
            resultStatusStringValues.TryGetValue(_resultStatus, out methodName);
            return (TResponse)typeof(TResponse).GetMethod(methodName).Invoke(new object(), new object[] { });
        }

        

    }
}
