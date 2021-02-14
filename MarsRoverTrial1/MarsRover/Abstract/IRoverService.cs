using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Abstract
{
    public interface IRoverService
    {
        List<Rover> GetRoversByInput(List<string> input);
    }
}
