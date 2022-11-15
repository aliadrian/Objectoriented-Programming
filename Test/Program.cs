using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            //Cannot do this due to the private set:er:
            //person.Name = "Foo";

            //Set value by using Reflection:
            person.GetType().GetProperty("Name").SetValue(person, "Foo", null);
            Console.WriteLine(person.Name);
            int diceNumber = RandomUtils.Dice(6);
            Console.WriteLine(diceNumber);
            bool b1 = RandomUtils.Percentage(50);
            Console.WriteLine(b1);
        }
    }
    public class Person
    {
        public string Name { get; private set; }
    }

    static class RandomUtils
    {
        private static Random random = new Random();

        public static bool Percentage(int percentage)
        {
            percentage = random.Next(1, 100);

            if (percentage < 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int Dice(int dice)
        {
            dice = random.Next(1, 7);
            return dice;
        }

    }

}