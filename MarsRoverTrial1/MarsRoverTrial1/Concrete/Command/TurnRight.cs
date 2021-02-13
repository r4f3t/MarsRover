using MarsRoverTrial1.Abstract.Command;
using MarsRoverTrial1.Models;
using MarsRoverTrial1.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverTrial1.Concrete.Command
{
    public class TurnRight : ICommand
    {
        private Rover _rover;
        public TurnRight(Rover rover)
        {
            _rover = rover;
        }
        public void Execute()
        {
            var tempDirection = _rover.Direction;
            switch (_rover.Direction)
            {
                case Direction.North:
                    tempDirection = Direction.East;
                    break;
                case Direction.East:
                    tempDirection = Direction.South;
                    break;
                case Direction.South:
                    tempDirection = Direction.West;
                    break;
                case Direction.West:
                    tempDirection = Direction.North;
                    break;
                default:
                    break;
            }

            _rover.Direction = tempDirection;
        }
    }
}
