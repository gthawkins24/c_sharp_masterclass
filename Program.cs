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
            box.SetLength(-3);
            box.height = 4;
            box.width = 5;
            Console.WriteLine("box volume is " + box.GetVolume());
            box.DisplayInfo();
        }
    }
}