namespace Zoo___Class_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog(10);
            Console.WriteLine($"Dogs weight from start: {dog.Weight}");
            Console.WriteLine($"Cats weight from start: {cat.Weight}");

            var animals = new List<Animal>();
            animals.Add(cat); // Type substitution
            animals.Add(dog); // Type substitution

            dog.Eat(cat);
            Console.WriteLine($"Dogs new weight after burying the bones: {dog.Weight}");

            foreach (Animal animal in animals)
            {
                Dog food = new Dog(1);
                animal.Eat(food); // Dynamic binding

                Grass grass = new Grass(1);
                animal.Eat(grass);
            }

            Console.WriteLine($"Dogs new weight after burying the bones and eating chihuaha: {dog.Weight}");
            Console.WriteLine($"Cats weight after eating chihuaha: {cat.Weight}");
            Console.WriteLine($"Dogs weight after eating grass {dog.Weight}");
            Console.WriteLine($"Cats weight after eating grass {cat.Weight}");
        }
    }

    interface IEdible
    {
        public double Weight { get; set; }
    }

    class Grass : IEdible
    {
        public Grass(double weight)
        {
            Weight = weight;
        }

        public double Weight { get; set; }

    }

    abstract class Animal : IEdible
    {
        public Animal(double weight)
        {
            Weight = weight;
            MakeSound();
        }

        public abstract void MakeSound();

        public virtual void Eat(IEdible food)
        {
            Weight += food.Weight;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Weight: {Weight}";
        }

        public double Weight { get; set; }
    }

    class Cat : Animal
    {
        public Cat() : base(4.5)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Dog : Animal
    {
        public Dog(double weight) : base(weight)
        {
        }

        public override void Eat(IEdible food)
        {
            Weight += food.Weight * 0.8;
        }

        public override void MakeSound()
        {
            Console.WriteLine(Weight <= 1 ? "Arf" : "Woof");
        }
    }
}