using System;
using System.Collections.Generic;
using System.Text;
using MarsRoverTrial1.Abstract.Command;
namespace MarsRoverTrial1.Concrete
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
