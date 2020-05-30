using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Factory
{
    abstract class AbstractChatroom
    {
        public abstract void Register(User user);
        public abstract void SendTo(string from, string to, string message);
        public abstract void Send(string from, string message);
    }
}
