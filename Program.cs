using System;

namespace c_sharp_masterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Teelicious";
            string lastName = "Bohne";
            string fullName = string.Concat("", firstName, lastName, "");
            Console.WriteLine(fullName); // output:TeeliciousBohne
            Console.WriteLine(firstName.Substring(2)); // output:eelicious
            Console.WriteLine(firstName.ToLower()); // output:teelicious
            Console.WriteLine(firstName.ToUpper()); // output:TEELICIOUS
            Console.WriteLine(firstName.Trim()); // output:TeeliciousBohne
            Console.WriteLine(firstName.IndexOf('e')); // output: 1
            Console.WriteLine(String.IsNullOrWhiteSpace(firstName)); // output:false

            // In C#, the String.Format method is used to insert the object or variable value inside an string.
            // With the String.Format we can replace the value in the specified format.
            // Syntax:
            string newFirstName = String.Format("any string {0}", firstName);
            Console.WriteLine(newFirstName);
            Console.ReadLine();
        }
    }
}
