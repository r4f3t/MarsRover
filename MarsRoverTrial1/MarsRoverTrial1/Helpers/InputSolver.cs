using MarsRover.Abstract.Command;
using MarsRover.Concrete.Command;
using MarsRover.Models;
using MarsRover.Models.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace MarsRover.Helpers
{
    public static class InputSolver
    {
        public static Point GetCoordinate(string input)
        {
            var points = input.Split(' ');
            Point returnPoint = new Point(int.Parse(points[0]), int.Parse(points[1]));

            return returnPoint;
        }


        public static Tuple<Point, Direction> GetRoverInitialValues(string input)
        {
            //input character check by regex
            if (Regex.IsMatch(input, @"\d \d [NSEW]"))
            {
                var points = input.Split(' ');

                Point returnPoint = new Point(int.Parse(points[0]), int.Parse(points[1]));

                Direction returnDirection = (Direction)points[2].ToCharArray()[0];

                return new Tuple<Point, Direction>(returnPoint, returnDirection);
            }
            else
            {
                throw new InvalidCastException("Your Input is not correct.Input :" + input);
            }
        }

        public static List<ICommand> GetRoverCommandsByInput(Rover rover, string input)
        {
            //List that has command actions implenmented from ICommand
            List<ICommand> commands = new List<ICommand>();
            //input character check by regex
            if (Regex.IsMatch(input, @"[LRM]"))
            {
                foreach (var side in input)
                {
                    switch (side)
                    {
                        case 'L':
                            commands.Add(new TurnLeft(rover));
                            break;
                        case 'R':
                            commands.Add(new TurnRight(rover));
                            break;
                        case 'M':
                            commands.Add(new MoveForward(rover));
                            break;
                        default:
                            break;
                    }
                }

                return commands;
            }
            else
            {
                throw new InvalidCastException("Your Input is not correct.Input :" + input);
            }
        }
    }
}
