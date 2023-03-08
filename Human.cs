using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_masterclass
{
    // this class is a blueprint for a datatype
    class Human
    {
        // member variable    
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        public Human()
        {
            Console.WriteLine("constructor called. Object created");
        }

        // parameterized constructor
        public Human (string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}. I'm {3} years old and my eyes are {2}", firstName, lastName, eyeColor, age);
        }
    }
}
