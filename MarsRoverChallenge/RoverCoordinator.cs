using System;

namespace p45Rover
{
    //Summary
    //Manupulation of rover position
    public class RoverCoordinator
    {
        public int x; //x Coordinate of the current rover position
        public int y; //y coordinate of the currentl rover position
        public string direction; //cardial direction of the current rover position

        public RoverCoordinator(string location) //Location = "1 2 N"
        {
            int.TryParse(location.Split(" ")[0], out x);
            int.TryParse(location.Split(" ")[1], out y);
            direction = location.Split(" ")[2];
        }

        public void SpinRight()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        /// <summary>
        /// Rover move orientation
        /// //In order to control a rover, NASA sends a simple string of letters.
        /// The possible letters are 'L', 'R' and 'M'. 'L' and 'R' makes the rover spin 90 degrees left or right respectively
        /// </summary>
        public void Spin90Degree(string roverMovingCommand)
        {
            char[] instructions = roverMovingCommand.ToCharArray();
            for (int strOfLetters = 0; strOfLetters < instructions.Length; strOfLetters++)
            {
                switch (instructions[strOfLetters])
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        MoveForward(); //'M' means move forward one grid point, and maintain the same heading.
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }
        /// <summary>
        /// Rover move orientation
        /// A rover's position is represented by a combination of an x and y co-ordinates and a letter representing one of the four cardinal compass points.
        /// </summary>
        public void MoveForward()
        {
            switch (direction)
            {
                case "N":
                    y += 1; //Assume that the square directly North from (x, y) is (x, y+1).
                    break;
                case "E":
                    x += 1;
                    break;
                case "S":
                    y -= 1;
                    break;
                case "W":
                    x -= 1;
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        /// <summary>
        /// Right 90 degree orientation function
        /// </summary>
        public void SpinLeft()
        {
            switch (direction)
            {
                case "N":
                    direction = "W"; //North 90 degrees right => North
                    break;
                case "E":
                    direction = "N"; //Est 90 degrees right => South
                    break;
                case "S":
                    direction = "E"; //South 90 degrees right => Est
                    break;
                case "W":
                    direction = "S"; //West 90 degrees right => South
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
