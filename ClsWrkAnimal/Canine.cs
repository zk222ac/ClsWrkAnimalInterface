using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    class Canine :Animal
    {
        public Canine(int id, string name, string location) : base(id, name, location)
        {
        }

        public override string Eat()
        {
            return "The members of canine family has same eating habit";
        }

        public override string Sleep()
        {
            return "The members of canine family has same sleeping habit";
        }
    }
}
