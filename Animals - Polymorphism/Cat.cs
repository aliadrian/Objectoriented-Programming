using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals___Polymorphism
{
    class Cat : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("Meow meow");
        }
    }
}
