using System;

namespace Mediator_Factory
{
     class Bot : ChatMember
    {
        public override string Name { get; set; }

        public Chatroom Chatroom { set; get; }

        public Bot(string name)
        {
            Name = name;
        }        
        public override void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: {2}", from, Name, message);
        }

        public override void Send(string message)
        {
            Chatroom.Send(Name, message);
        }

        public override void SendTo(string to, string message)
        {
            Chatroom.SendTo(Name, to, message);
        }

        public bool CheckMessage(string message)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            string[] words = message.ToLower().Split(delimiterChars ,StringSplitOptions.RemoveEmptyEntries) ;
            foreach (var word in words)
            {
                if (word == "cat" || word ==  "cats")
                {
                    return true;
                }
            }
            return false;
        }
    }
}