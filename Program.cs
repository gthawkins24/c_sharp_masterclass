using System;

namespace c_sharp_masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            int test2 = Add(Add(1, 2), Add(3, 4));
            Console.WriteLine(test2);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}