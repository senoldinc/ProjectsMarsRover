using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsMarsRover.Service
{
    //note for me : todo: create a interface and another costructor.
    public class Rover
    {
        public int x;// x coordinate of current rover position 
        public int y; // y coordinate of current rover position
        public string direction; //direction of current rover position
        public Plataeu plataeu; // our plateu

        /// <summary>
        /// 
        /// </summary>
        /// <param name="location">location format should be : 1 2 N</param>
        /// <param name="plataeu">Non-nullable plateu object</param>
        /// <exception cref="Exception"></exception>
        public Rover(string location, Plataeu plataeu)//this can be changed by initilaze method.
        {
            if (string.IsNullOrEmpty(location))
            {
                throw new Exception("Validation error. Rover should be location");
            }
            var locationParser = location.Split(' ');
            if (locationParser.Length == 0)
            {
                throw new Exception("Wrong seperator. Location seperator should be space");
            }
            if (locationParser.Length != 3)
            {
                throw new Exception("Wrong location format. Location Format should be : 1 2 N");
            }
            if (plataeu == null)
            {
                throw new Exception("Define object. Plataeu must be defined");
            }
            
            Int32.TryParse(locationParser[0], out x);
            Int32.TryParse(locationParser[1], out y);
            direction = locationParser[2];
            this.plataeu = plataeu;
        }



        public void Move(string roverCommand)
        {
            var movements = roverCommand.Trim().ToCharArray();
            for (int i = 0; i < movements.Length; i++)
            {
                switch (movements[i])
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        MoveForward();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
           
        }

        public void MoveForward()
        {
            switch (direction)
            {
                case "N":
                    if (y + 1 <= plataeu.height)
                        y += 1;
                    break;

                case "E":
                    if (x + 1 <= plataeu.width)
                        x += 1;
                    break;

                case "S":
                    if (y - 1 >= 0)
                        y -= 1;
                    break;

                case "W":
                    if (x - 1 >= 0)
                        x -= 1;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }


        public void TurnLeft()
        {
            switch (direction)
            {
                case "N":
                    direction = "W";
                    break;

                case "W":
                    direction = "S";
                    break;

                case "S":
                    direction = "E";
                    break;

                case "E":
                    direction = "N";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void TurnRight()
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
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            return $"{x} {y} {direction}";
        }

    }
}
