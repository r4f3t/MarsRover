using MarsRover.Abstract.Command;
using MarsRover.Models;
using MarsRover.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Concrete.Command
{
   public class TurnLeft:ICommand
    {
        private Rover _rover;
        public TurnLeft(Rover rover)
        {
            _rover = rover;
        }

        public void Execute()
        {
            var tempDirection = _rover.Direction;
            switch (_rover.Direction)
            {
                case Direction.North:
                    tempDirection = Direction.West;
                    break;
                case Direction.East:
                    tempDirection = Direction.North;
                    break;
                case Direction.South:
                    tempDirection = Direction.East;
                    break;
                case Direction.West:
                    tempDirection = Direction.South;
                    break;
                default:
                    break;
            }

            _rover.Direction = tempDirection;
        }
    }
}
