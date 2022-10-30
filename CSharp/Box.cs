using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Box
    {
        // Member variables
        private string color = "white";
        private int length = 3;
        private int height;
        // public int width;
        private int volume;

        public int Width { get; set; }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.Width = width;
        }

        public int Volume
        {
            get
            {
                return Height * Width * Length;
            }
            set
            {
                volume = value;
            }

        }

        // Read only
        public int Height
        {
            get
            {
                return height;
            }
            /*
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
            */
        }

        public int Length
        {
            get => length;
            set => length = value;
        }

        /*
        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
            }
        }
        */
        /*
        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }
        */

        public int FrontSurface
        {
            get { return height * length; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} and volume is {3}",
                length, height, Width, volume = Width * height * length);
        }
    }
}
