using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    // Base Class
    class Animal
    {
        // 
        private int _id;
        private string _name;
        private string _picture;
        protected string _food;
        protected string _boundries;

        // constructor 
        public Animal(int id ,string name , string location)
        {
            _name = name;
            _id = id;
            _boundries = location;

        }

        public virtual string MakeNoise()
        {
            return "Every animal make a noise";
        }
        public virtual string Eat()
        {
            return "Every animal has a eating habit";
        }

        public virtual string Sleep()
        {
            return "Every animal sleeps in a certain time";
        }

       

        public override string ToString()
        {
            return $"{_name} - {_boundries}";
        }
    }
}
