using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Command
{
    class ChangeExerciseCommand : ICommand
    {
        private Subject _subject;
        public ChangeExerciseCommand(Subject subject)
        {
            if (subject.State == "one")
            {
                subject.State = "two";
            }
            else if (subject.State == "two")
            {
                subject.State = "one";
            }
            _subject = subject;
        }

        public void Execute()
        {
            Console.WriteLine($"Инструктор: Now we are doing exercise {_subject.State}");
        }
    }
}
