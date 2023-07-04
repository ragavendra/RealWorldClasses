using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldClasses.User
{
    /// <summary> Receives the command from the User and runs it. </summary>
    public class RemoteA
    {
        private readonly ICommand _command;

        public RemoteA(ICommand command)
        {
            _command = command;
        }

        public void Execute() => _command.Execute();

        /*

        public void PressRight() => _command.MoveRight();

        public void PressLeft() => _command.MoveLeft();*/
    }
}