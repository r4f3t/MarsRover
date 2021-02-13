using MarsRoverTrial1.Models;
using MarsRoverTrial1.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverTrial1.Concrete.Command
{
   public class MoveForward
    {
        private Rover _rover;
        public MoveForward(Rover rover)
        {
            _rover = rover;
        }
        public void Execute()
        {
            var tempCoordinate = _rover.Coordinate;
            switch (_rover.Direction)
            {
                case Direction.North:
                    tempCoordinate.Y += 1;
                    break;
                case Direction.South:
                    tempCoordinate.Y -= 1;
                    break;
                case Direction.West:
                    tempCoordinate.X -= 1;
                    break;
                case Direction.East:
                    tempCoordinate.X += 1;
                    break;
                default:
                    break;
            }

            _rover.Coordinate = tempCoordinate;
        }
    }
}
