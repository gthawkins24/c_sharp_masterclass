using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            // box.length = 3;
            box.SetLength(3);
            box.Height = -4;
            box.Width = 5;
            Console.WriteLine("Box volume is " + box.GetVolume());
            Console.WriteLine("Box width: " + box.Width);
            box.DisplayInfo();
        }
    }
}