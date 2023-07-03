using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldClasses.User
{
    public class RemoteA
    {
        private readonly ICommand _command;

        public RemoteA(ICommand command)
        {
            _command = command;
        }

        public void PressRight()
        {
            _command.Execute();
        }
    }
}