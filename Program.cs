using System;
using System.ComponentModel;

namespace c_sharp_masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter your second number:");
            string input2 = Console.ReadLine();
            int parse = Int32.Parse(input1 + input2);
            int sum = (Int32.Parse(input1) + Int32.Parse(input2));
            Console.WriteLine($"{input1} + {input2} = {sum}");
            Console.Read();
        }
    }
}