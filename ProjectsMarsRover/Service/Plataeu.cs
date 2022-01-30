
namespace ProjectsMarsRover.Service
{
    public class Plataeu
    {
        public int width;
        public int height;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="size">platue format should be 5 5</param>
        /// <exception cref="Exception"></exception>
        public Plataeu(string size)
        {
            if (string.IsNullOrEmpty(size))
            {
                throw new Exception("Validation error. Plateu should be size");
            }
            var sizeParser = size.Split(' ');
            if (sizeParser.Length == 0)
            {
                throw new Exception("Wrong seperator. Size seperator should be space");
            }
            if (sizeParser.Length != 2)
            {
                throw new Exception("Wrong size format. Size format should be : 5 5");
            }

            Int32.TryParse(sizeParser[0], out width);
            Int32.TryParse(sizeParser[1], out height);
        }

    }
}
