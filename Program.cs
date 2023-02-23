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
            int num1 = 5;
            int num2 = 3;
            int num3;
            
            //unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = false;
            Console.WriteLine("is it sunny? {0}", !isSunny);

            // increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            Console.WriteLine("num is {0}", ++num);
            Console.WriteLine(num);

            // multiply and divide
            int result;

            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);

            // relational and type operators
            bool isLower;
            isLower = num1 > num2;
            Console.WriteLine("False or True: {0}", isLower);

            // equality operator
            bool isEqual;
            string yesOrNo;
            num1 = 4;
            num2 = 4;
            isEqual = num1 == num2;
            if (isEqual)
            {
                yesOrNo = "Yep!";
            }
            else
            {
                yesOrNo = "Nope!";
            }
            Console.WriteLine("Are they equal: {0}. Number 1: {1}, Number 2: {2}", yesOrNo, num1, num2);

            // conditional operators
            bool isLowerAndSunny = isSunny && isLower;
            Console.WriteLine("Is it sunny and lower: {0}", isLowerAndSunny);

            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("Is it lower or sunny?: {0}", isLowerAndSunny);
            Console.ReadKey();
        }
    }
}