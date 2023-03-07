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
            // create an object of my class
            // an instance of Human
            Human denis = new Human();
            // access public variable from outside, and even change it
            denis.firstName = "Denis";
            // call methods of the class
            denis.IntroduceMyself();

            Human michael = new Human();
            michael.IntroduceMyself();
        }
    }
}