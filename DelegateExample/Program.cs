namespace DelegateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person { FullName = "Kalle Anka", YearOfBirth = 1959},
                new Person { FullName= "Foo Bar", YearOfBirth = 1987 },
                new Person { FullName= "Speedy Gonzales", YearOfBirth = 1994 }
            };

            List<Person> SortedPeople = people.OrderBy(p => p.FullName).ToList();

            foreach (Person p in SortedPeople)
            {
                Console.WriteLine(p.FullName);
            }

            Console.WriteLine();

            // Named method
            people.Sort(GetSortCondition);

            people.Sort((a, b) =>
            {
                if (a.YearOfBirth < b.YearOfBirth)
                {
                    return -1;
                }
                if (a.YearOfBirth > b.YearOfBirth)
                {
                    return 1;
                }

                return 0;
            });

            foreach (Person p in people)
            {
                Console.WriteLine($"{p.FullName} {p.YearOfBirth}");
            }

            static int GetSortCondition(Person a, Person b)
            {
                if (a.YearOfBirth < b.YearOfBirth)
                {
                    return -1;
                }
                if (a.YearOfBirth > b.YearOfBirth)
                {
                    return 1;
                }

                return 0;
            }

            //var result = from p in people
            //             where p.FullName == "Foo Bar"
            //             select p;
        }
    }
}