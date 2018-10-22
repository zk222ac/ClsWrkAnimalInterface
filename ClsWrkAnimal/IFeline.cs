using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
     interface IFeline : ICanine
    {
        // No implementation - method with block of statment 
        // we also called abstract method
        string Roam();
    }

    
}
