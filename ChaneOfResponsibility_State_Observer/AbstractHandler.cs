using System;
using System.Collections.Generic;
using System.Text;

namespace ChaneOfResponsibility_State_Observer
{
    abstract class AbstractHandler : IHandler
    {

        private IHandler _nextHandler;

        public abstract void TransitionTo(State state);
        public abstract void ChangeStateToAwaiting();

        public abstract void ChangeStateToPreparing();

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }

        public virtual object HandlePackage(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.HandlePackage(request);
            }
            else 
            {
                return null;
            }
        }
    }
}
