using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Command
{
    public interface IObserver
    {
        public string Name { get; set; }
        // gets update from publisher
        void Update(ISubject subject);
    }
}
