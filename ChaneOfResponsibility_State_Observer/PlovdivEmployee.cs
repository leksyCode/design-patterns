using System;
using System.Collections.Generic;
using System.Text;

namespace ChaneOfResponsibility_State_Observer
{
    class PlovdivEmployee : AbstractEmployee
    {
        public override State _state { get; set; } = null;

        public PlovdivEmployee(State state)
        {
            this.TransitionTo(state);
        }

        public override void TransitionTo(State state)
        {
            Console.WriteLine($"  Plovdiv employee: state changed on {state.GetType().Name}.");
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
            if (request.ToString() == "package for Plovdiv")
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
