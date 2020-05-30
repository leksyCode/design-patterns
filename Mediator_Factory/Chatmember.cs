using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Factory
{
    abstract class ChatMember
    {
        public abstract string Name { get; set; }
        public abstract void Send(string message);
        public abstract void SendTo(string to, string message);
        public abstract void Receive(string from, string message);
    }
}
