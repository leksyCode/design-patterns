using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Factory
{
    class Chatroom : AbstractChatroom
    {
        private List<User> users = new List<User>();
        private Bot bot { get; set; } = null;

        public override void Register(User user)
        {
            if (!users.Contains(user))
            {
                users.Add(user);
            }
            user.Chatroom = this;
        }

        public override void Send(string from, string message)
        {
            if (bot != null)
            {
                if (bot.CheckMessage(message))
                {
                    bot.SendTo(from, $"{from} was kicked from chat for using the forbidden word 'cat'.");
                    users.Remove(users.Find(n => n.Name == from));
                }
            }

            Console.WriteLine(from + ": " + message);
            if (message == "addBot")
            {
                ChatMemberCreator creator = new BotCreator();
                bot = (Bot)creator.Create("bot");
                bot.Chatroom = this;
                bot.Send("is chat member now");
            }
        }

        public override void SendTo(string from, string to, string message)
        {
            if (bot != null)
            {
                if (bot.CheckMessage(message))
                {
                    bot.SendTo(from, $"{from} was kicked from chat for using the forbidden word 'cat'.");
                    users.Remove(users.Find(n => n.Name == from));
                    return;
                }
            }

            User user = users.Find(n => n.Name == to);

            if (user != null)
            {
                user.Receive(from, message);
            }    
            
        }
    }
}
