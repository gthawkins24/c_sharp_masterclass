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
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
            int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception: please enter a number");
                throw;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is too long");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No Number entered");
            }
            finally
            {
                Console.WriteLine("you finally entered a number!");
            }

            Console.ReadKey();
        }
    }
}