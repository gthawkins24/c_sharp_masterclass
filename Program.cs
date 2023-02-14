using System;

namespace c_sharp_masterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Tee Bohne";
            int age = 9;

            // String Concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old.");

            // String Formatting
            // string formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello, my name is {0} and I am {1} years old.", name, age);

            // String Interpolation
            // String interpolation uses $ at the start which will allow us to write out variables like this: {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");

            // Verbatim Strings
            // Literally and ignore any spaces and escape characters
            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer interdum pretium libero sit amet hendrerit. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Ut varius nibh eget orci mattis finibus. Etiam odio mauris, condimentum eget tortor non, gravida laoreet orci. Nam placerat, magna ut gravida euismod, urna est porttitor sem, id condimentum dui diam id purus. Donec ligula quam, lacinia eu nulla eu, vehicula egestas enim. Donec eu massa turpis.");

            Console.ReadLine();
        }
    }
}
