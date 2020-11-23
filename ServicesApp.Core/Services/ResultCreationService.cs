using System;
using System.Collections.Generic;
using System.Text;
using Ardalis.Result;
using ServicesApp.Core.Interfaces;

namespace ServicesApp.Core.Services
{
    public class ResultCreationService : IResultCreationService
    {
        public Result<T> CreateResult<T>(T result)
        {
            return Result<T>.NotFound();
        }
    }
}
