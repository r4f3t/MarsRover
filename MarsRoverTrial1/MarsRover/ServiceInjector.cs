using MarsRover.Abstract;
using MarsRover.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public static class ServiceInjector
    {
        public static ServiceProvider Register()
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                .AddSingleton<IRoverService, RoverService>()
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
