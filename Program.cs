using System;

namespace c_sharp_masterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your name and press enter");

            string input = Console.ReadLine();
            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());
            Console.WriteLine(input.Trim());
            Console.WriteLine(input.Substring(0));
        }
    }
}
