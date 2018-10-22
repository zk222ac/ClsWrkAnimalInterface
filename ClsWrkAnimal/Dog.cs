using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    class Dog : Animal ,  ICanine
    {
        public override string Eat()
        {
            return "Dog also eat flesh food";
        }

        public override string Sleep()
        {
            return "Dog mostly sleeps in the night";
        }

        public Dog(int id, string name, string location) : base(id, name, location)
        {
        }
    }
}
