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
            Console.WriteLine("What is the temperature?");
            string tempInput = Console.ReadLine();
            int temperature = Convert.ToInt32(tempInput);

            if (temperature < 60)
            {
                Console.WriteLine("Take the coat");
            }
            else if (temperature == 60)
            {
                Console.WriteLine("you good");
            }
            else
            {
                Console.WriteLine("Cozy & Warm");
            }
                Console.Read();
        }
    }
}