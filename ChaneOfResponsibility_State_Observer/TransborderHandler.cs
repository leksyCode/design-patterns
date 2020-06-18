using System;
using System.Collections.Generic;
using System.Text;

namespace ChaneOfResponsibility_State_Observer
{
    class TransborderHandler : AbstractHandler
    {
        private State _state = null;

        public TransborderHandler(State state)
        {
            this.TransitionTo(state);
        }

        public override void TransitionTo(State state)
        {
            Console.WriteLine($"Transborder employee: state changed on {state.GetType().Name}.");
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

        public override object HandlePackage(object request)
        {
            if ((request as string) == "Transborder package")
            {
                this.ChangeStateToPreparing();
                return $"Transborder employee: took the package.\n";
            }
            else
            {
                return base.HandlePackage(request);
            }
        }
    }
}
