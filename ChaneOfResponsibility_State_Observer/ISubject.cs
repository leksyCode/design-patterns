using System;
using System.Collections.Generic;
using System.Text;

namespace ChaneOfResponsibility_State_Observer
{
    interface ISubject
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);
        void Notify();
    }
}
