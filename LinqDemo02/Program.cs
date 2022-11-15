namespace LinqDemo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new Person[]
  {
                new Person { Name = "Bo", Age = 20 },
                new Person { Name = "Li", Age = 30 },
                new Person { Name = "An", Age = 40 },
                new Person { Name = "Anna", Age = 50 },
                new Person { Name = "Adam", Age = 60 },
  };

            var q1 = people
                .Where(p => p.Age > 25)
                //.OrderBy(p => p.Name)
                .OrderBy(p => p.Age)
                .ThenBy(p => p.Name);

            foreach (var p in q1)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();

            var q2 = people
                .Where(p => p.Age < 25)
                .Count();

            Console.WriteLine(q2);

            Console.WriteLine();

            var q3 = people
                .Max(p => p.Age);
            Console.WriteLine(q3);

            Console.WriteLine();

            var q4 = people
                .MinBy(p => p.Age);
            Console.WriteLine(q4.Name);

            Console.WriteLine();

            var q5 = people
                .Average(p => p.Age);
            Console.WriteLine(q5);

            Console.WriteLine();

            var q6 = people
                .MaxBy(p => p.Name.Length);
            Console.WriteLine(q6.Name);

            Console.WriteLine();

            var q7 = people
                .SingleOrDefault(p => p.Name == "Bo");
            Console.WriteLine(q7?.Name);

            Console.WriteLine();

            var letters = people
                .MaxBy(p => p.Name.Length);

            var q8 = people
                .GroupBy(p => p.Name.Length);

            foreach (var p in q8)
            {
                Console.WriteLine($"Letters: {p.Key}, People: {p.Count()}");
            }
        }
    }
}
