using System;
using System.Collections.Generic;
using System.Text;

namespace ChaneOfResponsibility_State_Observer
{
    class AwaitingPackage : State
    {
        public override void SetAwaitingState()
        {
            this._employeeContext.TransitionTo(new AwaitingPackage());           
        }

        public override void SetPreparingState()
        {
            this._employeeContext.TransitionTo(new PreparingPakage());
        }
    }
}
