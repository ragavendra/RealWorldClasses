using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldClasses.User
{
    public class MoveRight : ICommand
    {
        public readonly GameConsole _gameConsole;

        public readonly int _command;

        public MoveRight(GameConsole gameConsole, int command)
        {
            _gameConsole = gameConsole;
            _command = command;
        }

        public void Execute()
        {
            // throw new NotImplementedException();
            _gameConsole.MoveToRight(_command);
            // return true;
        }
    }
}