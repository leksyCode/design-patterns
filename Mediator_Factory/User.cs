using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Factory
{
    class User : ChatMember        
    {
        public User(string name)
        {
            Name = name;
        }

        public override string Name { get; set; }

        public Chatroom Chatroom { set; get; }

        public override void SendTo(string to, string message)
        {
            Chatroom.SendTo(Name, to, message);
        }

        public override void Send(string message)
        {
            Chatroom.Send(Name, message);
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: {2}", from, Name, message);
        }
    }
}
