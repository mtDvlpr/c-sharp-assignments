﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    interface IPencil
    {
        bool CanWrite { get; }

        void Write(string message);

        void AfterSharpening();
    }
}
