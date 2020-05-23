using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Command
{
    class Instructor
    {
        private ICommand _onStart;

        private ICommand _onFinish;

        // Initialize commands
        public void SetOnStart(ICommand command)
        {
            this._onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            this._onFinish = command;
        }


        public void ChangeExercise()
        {
            if (this._onStart is ICommand)
            {
                this._onStart.Execute();
            }


            if (this._onFinish is ICommand)
            {
                this._onFinish.Execute();
            }
        }
    }

}
