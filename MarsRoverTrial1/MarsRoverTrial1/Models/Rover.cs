using MarsRoverTrial1.Models.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MarsRoverTrial1.Models
{
    public class Rover
    {
        public Point Plateau { get; set; }
        public Point Coordinate { get; set; }
        public Direction Direction { get; set; }
    }
}
