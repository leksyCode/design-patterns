using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Command
{
    public interface ISubject
    {
        public string Name { get; set; }
        public string State { get; set; }

        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }
}
