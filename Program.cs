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
            bool isAdmin;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your username:");
            userName = Console.ReadLine();

            if (isRegistered)
            {
                Console.WriteLine("Hi there, registered user");
                if (userName != "")
                {
                    Console.WriteLine("Hi there, " + userName);
                    if (userName.Equals("Admin"))
                    {
                        Console.WriteLine("Hi there, Admin");
                    }
                }
            }
        }
    }
}