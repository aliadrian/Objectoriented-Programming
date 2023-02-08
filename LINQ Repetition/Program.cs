namespace LINQ_Repetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planet[] planets = new Planet[]
            {
                new Planet{ Name = "Tellus", DistanceFromEarth = 0, Discovered = new DateTime(1, 1, 1) },
                new Planet{ Name = "Proxima Centauri B", DistanceFromEarth = 4.22, Discovered = new DateTime(2013, 11, 04) },
                new Planet{ Name = "Pandora", DistanceFromEarth = 4.37, Discovered = new DateTime(2009, 12, 18) },
            };

            //var q1 = planets
            //    .Where(p => p.DistanceFromEarth > 0)
            //    .Select(p => p.Name);

            //foreach (var planet in q1)
            //{
            //    Console.WriteLine(planet);
            //}
            // 1. beräkna summan på alla DistanceFromEarth
            Console.WriteLine("Task 1:");
            var q2 = planets
                .Sum(p => p.DistanceFromEarth);
            Console.WriteLine(q2);

            Console.WriteLine();

            // 2. skriv ut Discovered på den enda planeten som heter Pandora
            Console.WriteLine("Task 2:");
            var q3 = planets
                .Where(p => p.Name == "Pandora")
                .Select(p => p.Discovered);
            //foreach (var planet in q3)
            //{
            //    Console.WriteLine(planet);
            //}

            Console.WriteLine();

            // 3. skriv ut planeternas namn i bokstavsordning
            Console.WriteLine("Task 3:");
            var q4 = planets
                .OrderBy(p => p.Name)
                .Select(p => p.Name);

            foreach (var planet in q4)
            {
                Console.WriteLine(planet);
            }

            var q5 = planets
                .SingleOrDefault(p => p.Name == "Pandora");
            Console.WriteLine(q5);

            var q6 = planets
                .MaxBy(p => p.DistanceFromEarth).Name;
            Console.WriteLine(q6);

            var q7 = planets
                .MinBy(p => p.Discovered);
            Console.WriteLine(q7.Name);
        }
    }

    class Planet
    {
        public string Name { get; set; }
        public double DistanceFromEarth { get; set; }
        public DateTime Discovered { get; set; }

        public override string ToString()
        {
            return $"{Name} {DistanceFromEarth} {Discovered}";
        }
    }
}