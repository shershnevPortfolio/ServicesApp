﻿using System;
using System.Collections.Generic;
using System.Text;
using ServicesApp.Core.Interfaces;

namespace ServicesApp.Core.Commands
{
    public class LoginCommand : ICommand
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Result { get; set; }
    }
}