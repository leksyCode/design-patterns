using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Command
{

    class Subject : ISubject
    {

        public string State { get; set; } = "one";
        public string Name { get; set; }

        public Subject(string name)
        {
            Name = name;
        }

        
        private List<IObserver> _observers = new List<IObserver>();

       
        public void Attach(IObserver observer)
        {
            Console.WriteLine($"{Name}: Attached an observer = {observer.Name}.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine($"{Name}: Detached an observer  = {observer.Name}.");
        }

      
        public void Notify()
        {
            Console.WriteLine($"{Name}: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

       
        public void DoExercise()
        {
            Console.WriteLine($"{Name}: Look! I'm doing exercise {this.State}");

            this.Notify();
        }
    }
}
