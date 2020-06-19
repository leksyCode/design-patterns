using System;
using System.Collections.Generic;
using System.Text;

namespace ChaneOfResponsibility_State_Observer
{
     interface IObserver
    {
         void Update(AbstractEmployee subject);
    }
}
