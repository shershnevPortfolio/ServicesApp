using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;
using Microsoft.Extensions.Logging;
using ServicesApp.Core.Abstractions.Interfaces;

namespace ServicesApp.Core.RequestPostProcessors
{
    internal class SaveChangesRequestPostProcessor<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public SaveChangesRequestPostProcessor(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Process(TRequest request, TResponse response, CancellationToken cancellationToken)
        {
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
