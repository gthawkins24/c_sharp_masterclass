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
            int numTemp;
            if(int.TryParse(tempInput, out int number))
            {
                numTemp = number;
            }
            else
            {
                Console.WriteLine("You've entered a value that wasn't a number");
                numTemp = 0;
            }

            if (number < 60)
            {
                Console.WriteLine("Take the coat");
            }
            else if (number == 60)
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