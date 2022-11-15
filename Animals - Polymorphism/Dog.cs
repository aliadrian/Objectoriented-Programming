using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals___Polymorphism
{
    class Dog : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("Voff voff");
        }
    }
}
