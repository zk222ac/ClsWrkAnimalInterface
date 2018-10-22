using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    class Wolf : Animal, ICanine
    {
       public override string Eat()
       {
           return "Wolf eat flesh animals";
       }

        public override string Sleep()
        {
            return "Wolf has odd sleeping habit";
        }

        public Wolf(int id, string name, string location) : base(id, name, location)
        {
        }
    }
}
