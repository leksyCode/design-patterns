using System;
using System.Collections.Generic;
using System.Text;

namespace ChaneOfResponsibility_State_Observer
{

    // Базовый класс Состояния объявляет методы, которые должны реализовать все
    // Конкретные Состояния, а также предоставляет обратную ссылку на объект
    // Контекст, связанный с Состоянием. Эта обратная ссылка может
    // использоваться Состояниями для передачи Контекста другому Состоянию.
    abstract class State
    {
        protected AbstractHandler _employeeContext;

        public void SetContext(AbstractHandler context)
        {
            this._employeeContext = context;
        }

        public abstract void SetAwaitingState();

        public abstract void SetPreparingState();
    }
}
