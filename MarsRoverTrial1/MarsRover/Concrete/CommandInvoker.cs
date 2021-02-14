using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.Abstract.Command;
namespace MarsRover.Concrete
{
    public class CommandInvoker
    {
        private ICommand _command;
        public CommandInvoker()
        {
        }

        public void SetCommand(ICommand command) => _command = command;

        public void Invoke()
        {
            _command.Execute();
        }
    }
}
