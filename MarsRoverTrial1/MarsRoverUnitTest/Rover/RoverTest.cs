using MarsRover.Concrete;
using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRoverUnitTest.Rovers
{
    public class RoverTest
    {
        [Theory]
        [MemberData(nameof(TestInputData.Data), MemberType = typeof(TestInputData))]
        public void CreateRoverObject(List<string> inputs)
        {
            RoverService roverService = new RoverService();
            List<Rover> rovers = roverService.GetRoversByInput(inputs);

            int expectedRoverCount = (inputs.Count) / 2;
            Assert.Equal(expectedRoverCount, rovers.Count);
        }


        [Theory]
        [MemberData(nameof(TestInputData.InvalidData), MemberType = typeof(TestInputData))]
        public void CheckRoverInputData(List<string> inputs)
        {
            RoverService roverService = new RoverService();

            Assert.Throws<InvalidCastException>(()=>roverService.GetRoversByInput(inputs));

        }


    }


    public class TestInputData
    {
        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] {  new List<string>(){"5 5", "1 2 N", "LMLMLMLMM", "3 4 S", "RMRMRMRMM" } }
            };

        public static IEnumerable<object[]> InvalidData =>
          new List<object[]>
          {
                new object[] {  new List<string>(){"5 5", "1 2 N", "LMLMLMLMM", "3 4 S", "RAFET" } }
          };
    }
}
