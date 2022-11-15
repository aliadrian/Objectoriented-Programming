using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals___Polymorphism
{
    interface IAnimal
    {
        void animalSound();
        void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
}
