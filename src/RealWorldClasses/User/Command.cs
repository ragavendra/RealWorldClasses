using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldClasses.User
{
    public class Command : ICommand
    {
        public readonly GameConsole _gameConsole;

        public readonly int _command;

        public Command(GameConsole gameConsole, int command)
        {
            _gameConsole = gameConsole;
            _command = command;
        }

        public void Execute() => _gameConsole.Execute();

/*
        public void A()
        {
            throw new NotImplementedException();
        }

        public void B()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            // throw new NotImplementedException();
            _gameConsole.MoveToRight(_command);
            // return true;
        }

        public void MoveDown()
        {
            throw new NotImplementedException();
        }

        public void MoveLeft()
        {
            throw new NotImplementedException();
        }

        public void MoveUp()
        {
            throw new NotImplementedException();
        }

        public void Select()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void X()
        {
            throw new NotImplementedException();
        }

        public void Y()
        {
            throw new NotImplementedException();
        }

        public void MoveRight()
        {
            _gameConsole.MoveToRight(_command);
        }*/

    }
}