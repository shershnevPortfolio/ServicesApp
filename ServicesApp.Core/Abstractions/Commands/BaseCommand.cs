using Ardalis.Result;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace ServicesApp.Core.Abstractions.Commands
{
    public abstract class BaseCommand : IRequest<Result<Unit>>
    {
    }
}
