using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsMarsRover.Service
{
    public class Rover
    {
        public int x; // x coordinate of current rover position 
        public int y; // y coordinate of current rover position
        public string direction; //direction of current rover position

        public Rover(string location)
        {
            if (string.IsNullOrEmpty(location))
            {
                throw new Exception("Rover should be location");
            }
            var locationParser = location.Split(' ');
            if (locationParser.Length == 0)
            {
                throw new Exception("Location seperator should be space");
            }
            if (locationParser.Length != 3)
            {
                throw new Exception("Wrong location format. Location Format should be : 1 2 N");
            }
            
            Int32.TryParse(locationParser[0], out x);
            Int32.TryParse(locationParser[1], out y);
            direction = locationParser[2];
        }


    }
}
