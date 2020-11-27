using Ardalis.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Interfaces
{
    internal interface IResultCreationService
    {
        Result<T> CreateResult<T>(T result);
    }
}
