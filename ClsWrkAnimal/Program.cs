using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>()
            {
                new Lion(12, "Lion" , "23 sq meter"),
                new Tiger(45, "Tiger" , "45 sq meter"),
                new Cat(67, "Cat" , "2 meter"),
                new Hippo(23,"Hippo" , "3 sq meter"),
                new Wolf(53,"wolf" ," forest"),
                new Dog(56,"Dog" , "home compound area"),
            };

            foreach (var lis in list)
            {
                Console.WriteLine($"Name and location :{lis} |, sound:{lis.MakeNoise()}");
            }
            Console.WriteLine("--------------------------------------------------------------");

            IFeline lion = new Lion(34 , "Lion" , "25 sqm");
            IFeline tiger = new Tiger(34, "Tiger", "25 sqm");
            ISwim swim = new Tiger(34,"Tiger" , "34 sq");

            Console.WriteLine(lion.Roam());
            Console.WriteLine(tiger.Roam());
            Console.WriteLine(swim.Swim());
            


            Console.ReadKey();

        }
    }
}
