using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
   
    class Cat : Animal
    {
        private int _id;


        public Cat(int id, string name, string location) : base(id, name, location)
        {
            _id = id;
        }

        public override string MakeNoise()
        {
            return "Cat is Mowing";
        }

        public override string Eat()
        {
            return "Cat is eating ready made food";
        }
    }
}
