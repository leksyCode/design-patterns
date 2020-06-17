using System;
using System.Collections.Generic;
using System.Text;

namespace ChaneOfResponsibility_State_Observer
{
    abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;


        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            // Возврат обработчика отсюда позволит связать обработчики простым
            // способом, вот так:
            // monkey.SetNext(squirrel).SetNext(dog);
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}
