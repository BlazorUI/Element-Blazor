﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazui.Component
{
    public class ExceptionHandle
    {
        internal readonly Func<Exception, string, Task> handler;

        public ExceptionHandle(Func<Exception, string, Task> handler)
        {
            this.handler = handler;
        }
    }
}
