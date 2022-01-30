using ProjectsMarsRover.Service;
using Xunit;

namespace ProjectsMarsRover.Tests
{
    public class RoverTest
    {

        [Fact]
        public void MoveForvard()
        {
            var plateu = new Plataeu("5 5");
            var rover = new Rover("1 2 N", plateu);
            rover.MoveForward();
            Assert.Equal(3, rover.y);
        }

        [Fact]
        public void TurnLeft()
        {
            var plateu = new Plataeu("5 5");
            var rover = new Rover("1 2 N", plateu);
            rover.TurnLeft();
            Assert.Equal("W", rover.direction);
        } 
        
        [Fact]
        public void TurnRight()
        {
            var plateu = new Plataeu("5 5");
            var rover = new Rover("1 2 N", plateu);
            rover.TurnRight();
            Assert.Equal("E", rover.direction);
        }

        [Fact]
        public void Move()
        {
            var plateu = new Plataeu("5 5");
            var rover = new Rover("3 3 E", plateu);
            rover.Move("MMRMMRMRRM");
            Assert.Equal("5 1 E", rover.ToString());
        }


    }
}