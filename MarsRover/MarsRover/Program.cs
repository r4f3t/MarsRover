using MarsRover.Abstract;
using MarsRover.Concrete;
using MarsRover.Helpers;
using MarsRover.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            //Connect Service injector Get concrete class of service interfaces
            ServiceProvider serviceProvider = ServiceInjector.Register();
            IRoverService roverService = serviceProvider.GetService<IRoverService>();
            
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
