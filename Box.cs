using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_masterclass
{
    internal class Box
    {
        // member variables
        private int length = 3;
        private int height;
        // public int width;
        public int volume;

        public int Width { get; set; }

        public int Height
        {
            get
            {
                return height;
            }
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
        }

        // setter
        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }

            this.length = length;
        }

        // getter
        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            return this.length * this.height * Width;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2}. Volume: {3}", length, height, Width, volume = length*height*Width);
        }
    }
}
