namespace Animals___Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            IAnimal myDog = new Dog();
            IAnimal myCat = new Cat();

            myPig.animalSound();

            myDog.animalSound();
            myDog.sleep();
            myCat.animalSound();

            Console.WriteLine();

            Chocolate ch = new Chocolate();
            ch.flavor();
            Console.ReadKey();
            Console.Clear();

            Program p = new Program();
            p.save();
            p.save("Adrian");
            DateTime dt = DateTime.Now;
            p.save("Adrian", 26, dt.ToShortDateString());
            Console.ReadKey();
            Console.Clear();

            Tesla tesla = new Tesla(14);
            Console.WriteLine($"Teslas tyresize from start: {tesla.TyreSize}");
            Tyre tyre = new Tyre(1);
            tesla.Wheel(tyre);
            Console.WriteLine($"Teslas new size of tyre: {tesla.TyreSize}");
        }

        public void save()
        {
            Console.WriteLine("No data saved");
        }

        public void save(string name)
        {
            Console.WriteLine($"saves {name}");
        }

        public void save(string name, int age)
        {
            Console.WriteLine($"saved {name} and {age}");
        }

        public void save(string name, int age, string date)
        {
            Console.WriteLine($"{name} and {age} are saved on {date}");
        }
    }

    interface ITyreSize
    {
        public double TyreSize { get; set; }
    }

    abstract class Vehicle
    {
        public double TyreSize { get; set; }
        public Vehicle(double tyreSize)
        {
            Console.WriteLine("Class : Vehicle");
            TyreSize = tyreSize;
        }
        public virtual void Wheel(ITyreSize tyreSize)
        {
            Console.WriteLine("TyreSize : Vehicle");
        }
    }

    class Tyre : ITyreSize
    {

        public double TyreSize { get; set; }
        public Tyre(double tyreSize)
        {
            TyreSize = tyreSize;
        }
    }

    class Tesla : Vehicle
    {
        public Tesla(int tyreSize) : base(tyreSize)
        {

        }

        public override void Wheel(ITyreSize tyreSize)
        {
            TyreSize += tyreSize.TyreSize * 1.5;
            //Console.WriteLine("TyreSize : 5");
        }
    }

    class IceCream
    {
        public IceCream()
        {
            Console.WriteLine("Class : IceCream");
        }

        public virtual void flavor()
        {
            Console.WriteLine("IceCream Type : Vanilla");
        }
    }

    class Chocolate : IceCream
    {
        public Chocolate()
        {
            Console.WriteLine("Class : Chocolate");
        }
        public override void flavor()
        {
            Console.WriteLine("IceCream Type : Chocolae");
        }
    }
}