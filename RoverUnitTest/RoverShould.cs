using Xunit;

namespace p45Rover
{
    public class RoverShould
    {
        [Fact]
        public void SpinLeft()
        {
            //arrange,
            RoverCoordinator rover = new RoverCoordinator("1 2 N");
            //act,
            rover.SpinLeft();
            //assert
            Assert.Equal("W", rover.direction);
        }
        [Fact]
        public void SpinRight()
        {
            //arrange,
            RoverCoordinator rover = new RoverCoordinator("1 2 N");
            //act,
            rover.SpinRight();
            //assert
            Assert.Equal("E", rover.direction);
        }
        [Fact]
        public void MoveForward()
        {
            //arrange,
            RoverCoordinator rover = new RoverCoordinator("1 2 N");
            //act,
            rover.MoveForward();
            //assert
            Assert.Equal(3, rover.y);
        }
        [Fact]
        public void Move()
        {
            //arrange,
            RoverCoordinator rover = new RoverCoordinator("3 3 E");
            //act,
            rover.Spin90Degree("MMRMMRMRRM");
            //assert
            Assert.Equal("5 1 E", rover.x + " " + rover.y + " " + rover.direction);
        }
    }
}

