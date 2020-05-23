using Observer_Command;
using System;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // client code
            var subject = new Subject("Трениращ");
            var observer = new OnlineObserver("Онлайн зрител №1");
            var observer2 = new OnlineObserver("Онлайн зрител №2");
            var observer3 = new OnlineObserver("Онлайн зрител №3");
            subject.Attach(observer);
            subject.Attach(observer2);
            subject.Attach(observer3);

            subject.DoExercise();

            Instructor instructor = new Instructor();
            instructor.SetOnStart(new ChangeExerciseCommand(subject));
            instructor.ChangeExercise();

            subject.DoExercise();
        }
    }
}
