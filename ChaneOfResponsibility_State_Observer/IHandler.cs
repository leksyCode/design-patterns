﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChaneOfResponsibility_State_Observer
{
    interface IHandler
    {
        IHandler SetNext(IHandler handler);

        bool HandlePackage(object request);
    }
}
