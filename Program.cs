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
            Human tBone = new Human("T-", "Bone", "Blue?", 34);
            Human keith = new Human("Keith", "Who Cares", "worst", 47);
            Human petey = new Human("Petey", "Noname", "blue", 14);
            tBone.IntroduceMyself();
            keith.IntroduceMyself();
            petey.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();
        }
    }
}