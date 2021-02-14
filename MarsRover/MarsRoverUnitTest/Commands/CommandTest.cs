

using MarsRover.Concrete;
using MarsRover.Concrete.Command;
using MarsRover.Models;
using MarsRover.Models.Enums;
using System.Drawing;
using Xunit;

namespace MarsRoverUnitTest.Commands
{
   public class CommandTest
    {
        [Fact]
        public void TurnLeft()
        {
            //Arrange Rover data for command test
            Plateau plateau = new Plateau();
            plateau.Coordinate = new Point(5, 5);

            Rover rover = new Rover(plateau, new Point(1, 2), Direction.North);

            //Act for command method
            CommandInvoker commandInvoker = new CommandInvoker();
            commandInvoker.SetCommand(new TurnLeft(rover));
            commandInvoker.Invoke();

            //Assertion of rover direction value
            Assert.Equal(Direction.West, rover.Direction);
        }

        [Fact]
        public void TurnRight()
        {
            //Arrange Rover data for command test
            Plateau plateau = new Plateau();
            plateau.Coordinate = new Point(5, 5);

            Rover rover = new Rover(plateau, new Point(1, 2), Direction.North);

            //Act for command method
            CommandInvoker commandInvoker = new CommandInvoker();
            commandInvoker.SetCommand(new TurnRight(rover));
            commandInvoker.Invoke();

            //Assertion of rover direction value
            Assert.Equal(Direction.East, rover.Direction);
        }

        [Fact]
        public void MoveForward()
        {
            //Arrange Rover data for command test
            Plateau plateau = new Plateau();
            plateau.Coordinate = new Point(5, 5);

            Rover rover = new Rover(plateau, new Point(1, 2), Direction.North);

            //Act for command method
            CommandInvoker commandInvoker = new CommandInvoker();
            commandInvoker.SetCommand(new MoveForward(rover));
            commandInvoker.Invoke();

            //Assertion of rover direction value
            Assert.Equal(new Point(1,3), rover.Coordinate);
        }

    }
}
