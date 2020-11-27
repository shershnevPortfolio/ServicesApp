﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Interfaces
{
    public interface ICommandHandler<TCommand> 
    {
        void Handle(TCommand command);

    }

    public interface ICommandHandler
    {
        void Handle<TCommand>(TCommand command);
    }
}
