using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    class Feline :Animal
    {
        public Feline(int id, string name, string location) : base(id, name, location)
        {
        }

        public override string Roam()
        {
            return "Feline group members have same roaming ability";
        }
    }
}
