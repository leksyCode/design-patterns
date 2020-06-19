using System;
using System.Collections.Generic;
using System.Text;

namespace ChaneOfResponsibility_State_Observer
{
    class ObserverEmployee : IObserver
    {
        public void Update(AbstractEmployee subject)
        {           
            if ((subject as AbstractEmployee)._state.GetType() == new PreparingPakage().GetType())
            {
                Console.WriteLine("  Observer employee go to the " + subject.GetType().Name + " and took the package");
                subject.ChangeStateToAwaiting();
            }
        }
    }
}
