using System;
using System.Collections.Generic;
using System.Text;

namespace ChaneOfResponsibility_State_Observer
{
    class CountryEmployee : AbstractEmployee
    {
        public override State _state { get; set; } = null;

        //private IObserver _observer = new ;

        public CountryEmployee(State state)
        {
            this.TransitionTo(state);
        }

        public override void TransitionTo(State state)
        {
            Console.WriteLine($"  Country employee: state changed on {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }
        public override void ChangeStateToAwaiting()
        {
            this._state.SetAwaitingState();
        }

        public override void ChangeStateToPreparing()
        {
            this._state.SetPreparingState();
        }
        public override bool HandlePackage(object request)
        {
            if (request.ToString() == "package for Country")
            {
                this.ChangeStateToPreparing();
                base.Notify();
                return true;
            }
            else
            {
                return base.HandlePackage(request);                
            }
        }
    }
}
