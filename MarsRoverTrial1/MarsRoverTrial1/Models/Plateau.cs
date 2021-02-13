using MarsRoverTrial1.Helpers;
using System.Drawing;

namespace MarsRoverTrial1.Models
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
