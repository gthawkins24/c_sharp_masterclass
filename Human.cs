using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_masterclass
{
    // this class is a blueprint for a datatype
    internal class Human
    {
        // member variable    
        public string firstName = "T-";
        public string lastName = "Bone";

        // member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }
    }
}
