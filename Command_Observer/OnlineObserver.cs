using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Command
{

    class OnlineObserver : IObserver
    {

        public string Name { get; set; }

        public OnlineObserver(string name)
        {
            Name = name;
        }

        public void Update(ISubject subject)
        {

            Console.WriteLine($"{Name} reacted to subject and begins to do exercise {subject.State}");

        }
    }
}
