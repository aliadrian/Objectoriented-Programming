namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pastries = new Pastry[]
            {
                new Pastry { Name = "Cheesecake", Cal = 321 },
                new Pastry { Name = "Muffin", Cal = 377 },
                new Pastry { Name = "Croissant", Cal = 406 },
            };

            var q1 = pastries
                .Where(p => p.Cal > 370)
                .OrderBy(p => p.Name);
            //.Select(p => p.Name);

            foreach (var pastry in q1)
            {
                Console.WriteLine(pastry);
            }

            Console.WriteLine();

            var q2 = pastries
                .Single(p => p.Name == "Muffin");
            Console.WriteLine(q2);

            Console.WriteLine();

            var q3 = pastries
                .Average(p => p.Cal);
            Console.WriteLine(q3);

            Console.WriteLine();

            var q4 = pastries
                .MaxBy(p => p.Cal);
            Console.WriteLine(q4.Name);

            Console.WriteLine();

            int i = 1;
            var q5 = pastries
                .Select(p => new
                {
                    Nr = i++,
                    Name = p.Name,
                    HighAmountOfCalories = p.Cal > 400
                }).ToArray();

            foreach (var p in q5)
            {
                Console.WriteLine(p);
            }
        }
    }

    class Pastry
    {
        public string Name { get; set; }
        public int Cal { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Cal} calories";
        }
    }
}