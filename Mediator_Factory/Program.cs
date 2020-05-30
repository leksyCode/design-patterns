using System;
using System.Collections.Generic;

namespace Mediator_Factory
{

    class Program
    {
        static void Main(string[] args)
        {
            Chatroom chatroom = new Chatroom();

            // Create users and register them
            ChatMemberCreator creator = new UserCreator();

            User Ivan = (User)creator.Create("Ivan");
            User Greenpeace = (User)creator.Create("Greenpeace");
            User Incognita = (User)creator.Create("Incognita");

            chatroom.Register(Ivan);
            chatroom.Register(Greenpeace);
            chatroom.Register(Incognita);

            // Chatting participants                
            Ivan.Send("Hello everyone!");
            Ivan.Send("I like to eat cats");
            Incognita.Send("addBot");
            Greenpeace.SendTo("Ivan", "In our country cats are forbidden, I call the police :D");
            Incognita.SendTo("Ivan", "Now you are free");
            Console.ReadKey();
        }
    }
}
