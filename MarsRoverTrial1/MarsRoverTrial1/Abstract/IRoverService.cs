using MarsRoverTrial1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverTrial1.Abstract
{
    public interface IRoverService
    {
        List<Rover> GetRoversByInput(List<string> input);
    }
}
