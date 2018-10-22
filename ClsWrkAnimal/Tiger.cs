using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    class Tiger : Animal , ISwim , IFeline
    {
        private int _id;


        public Tiger(int id, string name, string location) : base(id, name, location)
        {
            _id = id;
        }

        public override string MakeNoise()
        {
            return "Tiger is Chuffing";
        }

        public override string Eat()
        {
            return "Tiger is eating flesh animals";
        }

        // I swim and Ifeline 
        public string Swim()
        {
            return "sometime tiger swim in the water";
        }

        public string Roam()
        {
            return "Tiger also moves to certain position in the jungle";
        }
    }
}
