using MarsRover.Abstract;
using MarsRover.Helpers;
using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover.Concrete
{
    public class RoverService : IRoverService
    {

        public RoverService()
        {

        }
        public List<Rover> GetRoversByInput(List<string> input)
        {
            List<Rover> rovers = new List<Rover>();
            //Get Plateau points from input
            Plateau plateau = new Plateau();
            plateau.SetCoordinate(input[0]);

            //Remove first row that contains Plateau coordinates
            input.RemoveAt(0);

            //Find rover count by dividing input
            int roverCount = input.Count() / 2;

            //Create Rover objects
            for (int i = 0; i < roverCount; i++)
            {
                string coordinateString = input[i * 2];
                string commandString = input[(i * 2) + 1];

                //GetRover initial Point and Direction
                var roverInitialData = InputSolver.GetRoverInitialValues(coordinateString);
                
                //SetRover's Plateau ,Point and Direction
                Rover rover = new Rover(plateau, roverInitialData.Item1, roverInitialData.Item2);

                rover.Commands = InputSolver.GetRoverCommandsByInput(rover,commandString);
                

                //Add rover to return list
                rovers.Add(rover);
            }

            return rovers;
        }
    }
}
