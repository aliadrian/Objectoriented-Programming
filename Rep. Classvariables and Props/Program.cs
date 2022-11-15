namespace Rep._Classvariables_and_Props
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            //person.SetName("Adrian");
            //Console.WriteLine(person.GetName());

            //person.Name = null; // set
            Console.WriteLine(person.Name); // get

            DayOfWeek dayOfWeek = DayOfWeek.Monday;
            Console.WriteLine(dayOfWeek);
            Console.WriteLine((int)dayOfWeek);

            int enumVal = 3;
            Console.WriteLine((DayOfWeek)enumVal);

            string dayName = "Wednesday";
            Enum.TryParse(dayName, out DayOfWeek enumValFromString);
            Console.WriteLine(enumValFromString);

            int number = Random.Shared.Next(1, 10);
            Console.WriteLine($"One random number: {number}");

            Random rand = new Random();
            Console.Write("Random numbers: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{rand.Next(1, 10)}, ");
            }
        }
    }

    class Person
    {


        public Person()
        {
            Name = "Bo";
            Age = 10;
        }

        public int Age { get; private set; }

        string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }
                name = value;
            }
        }


        //public string name;

        //public string GetName()
        //{
        //    return name;
        //}

        //public void SetName(string name)
        //{
        //    if (name == null)
        //    {
        //        throw new ArgumentNullException("name");
        //    }
        //    this.name = name;
        //}



    }
}