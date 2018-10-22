using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    class Lion : Animal , IFeline
    {
        private int _id;
        private string _location;


        public Lion(int id, string name, string location) : base(id, name, location)
        {
            _id = id;
            _location = location;
        }

        public override string MakeNoise()
        {
            return "Lion is roaring";
        }

        public override string Eat()
        {
            return "Lion is eating flesh animals";
        }

        // Interface method
        public string Roam()
        {
            return "Lion moves to certain position in the jungle";
        }

        
    }
}
