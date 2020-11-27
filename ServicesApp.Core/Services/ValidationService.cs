using System;
using System.Collections.Generic;
using System.Text;
using ServicesApp.Core.Interfaces;

namespace ServicesApp.Core.Services
{
    internal class ValidationService : IValidationService
    {
        public void ValidateQuery<T>(T Query)
        {
            throw new NotImplementedException();
        }

        public void ValidateQueryResult<T>(T result)
        {
            throw new NotImplementedException();
        }
    }
}
