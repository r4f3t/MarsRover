using MarsRover.Abstract.Command;
using MarsRover.Models.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MarsRover.Models
{
    public class Rover
    {
        public Plateau Plateau { get; set; }
        public Point Coordinate { get; set; }
        public Direction Direction { get; set; }
        public List<ICommand> Commands { get; set; }
        public Rover(Plateau plateau,Point coordinate,Direction direction)
        {
            this.Plateau = plateau;
            this.Coordinate = coordinate;
            this.Direction = direction;
        }
    }
}
