using MarsRover.Helpers;
using System.Drawing;

namespace MarsRover.Models
{
    public class Plateau
    {
        public Point Coordinate { get; set; }
        public void SetCoordinate(string input)
        {
            this.Coordinate = InputSolver.GetCoordinate(input);
        }
    }
}
