using System;
using System.Collections.Generic;
using System.Drawing;

namespace MarsRoverTrial1
{
    class Program
    {
        static void Main(string[] args)
        {
            var plateu = new Point(5, 5);
            Rover rover1 = new Rover();
            rover1.Coordinate = new Point(1, 2);
            rover1.Direction = (Direction)'N';

            var input1 = "LMLMLMLMM";

            foreach (var item in input1)
            {
                Move(rover1, item);
            }

            Console.WriteLine(rover1.Coordinate.ToString() + " " + rover1.Direction.ToString());
            Console.ReadLine();
        }


        class Rover
        {
            public Point Coordinate { get; set; }
            public Direction Direction { get; set; }
        }

        static void Move(Rover rover, char side)
        {
            switch (side)
            {
                case 'L':
                    rover.Direction = GetNewDirection(rover.Direction, side);
                    break;
                case 'R':
                    rover.Direction = GetNewDirection(rover.Direction, side);
                    break;
                case 'M':
                    MoveForward(rover);
                    break;
                default:
                    break;
            }
        }

        static void MoveForward(Rover rover)
        {
            var tempCoordinate = rover.Coordinate;
            switch (rover.Direction)
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

            rover.Coordinate = tempCoordinate;
        }

        enum Direction
        {
            North = 'N',
            East = 'E',
            South = 'S',
            West = 'W'
        }

        static string DirectionIndexMap = "NESW";

        static Direction GetNewDirection(Direction direction, char side)
        {
            var index = DirectionIndexMap.IndexOf((char)direction);
            Direction newDirection = Direction.North;
            switch (side)
            {
                case 'L':
                    index = (index == 0) ? DirectionIndexMap.Length : index;
                    newDirection = (Direction)DirectionIndexMap[index - 1];
                    break;
                case 'R':
                    index = (index == DirectionIndexMap.Length - 1) ? 0 : index+1;
                    newDirection = (Direction)DirectionIndexMap[index];
                    break;
                default:
                    break;
            }

            return newDirection;
        }

    }
}
