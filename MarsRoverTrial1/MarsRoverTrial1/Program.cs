using MarsRoverTrial1.Concrete;
using MarsRoverTrial1.Helpers;
using MarsRoverTrial1.Models;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace MarsRoverTrial1
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverService roverService = new RoverService();
            CommandInvoker commandInvoker = new CommandInvoker();

            //Get Inputs
            List<string> inputs = InputGenerator.GetInputs();

            //Get Rovers by sending input parameters set commands of each rover
            List<Rover> rovers = roverService.GetRoversByInput(inputs);

            //Invoke Rover Commands
            foreach (var rover in rovers)
            {
                foreach (var command in rover.Commands)
                {
                    //Set each rover commands
                    commandInvoker.SetCommand(command);
                    commandInvoker.Invoke();
                }

            }

            //Show Output
            OutputHelper(rovers);

         
        }


        private static void OutputHelper(List<Rover> rovers)
        {
            foreach (var rover in rovers)
            {
                Console.WriteLine(rover.Coordinate.X+" "+rover.Coordinate.Y+" "+(char)rover.Direction);
            }
            Console.ReadLine();
        }


    }
}
