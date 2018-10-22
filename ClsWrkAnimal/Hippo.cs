using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    class Hippo : Animal , ISwim
    {
        public Hippo(int id, string name, string location) : base(id, name, location)
        {

        }

        // these two method belongs to animal class
        public override string Eat()
        {
            return "Hippo eat grass and vegatables";
        }

        public override string MakeNoise()
        {
            return "Hippo has churking sound";
        }

        // Swim method belongs to Iswim
        public string Swim()
        {
            return "Hippo usually spend time in the water";
        }

       
    }
}
