using System;
using System.Collections.Generic;
using System.Text;
using Ardalis.Result;
using ServicesApp.Core.Interfaces;

namespace ServicesApp.Core.Services
{
    internal class ResultCreationService : IResultCreationService
    {
        public Result<T> CreateResult<T>(T result)
        {
            throw new NotImplementedException();
        }
    }
}
