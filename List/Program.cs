using System.Linq;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[3] { "Mumbai", "London", "New York" };

            var popularCities = new List<string>();

            // adding an array in a List
            popularCities.AddRange(cities);

            var favouriteCities = new List<string>() { "Shanghai", "Tokyo" };

            // adding a List 
            favouriteCities.AddRange(popularCities);

            Console.WriteLine($"Number of popular cities: {popularCities.Count}");

            Console.Write("Popular cities: ");
            foreach (var city in popularCities)
            {
                Console.Write($"{city}, ");
            }

            Console.WriteLine("\n");

            Console.WriteLine($"Number of favourite cities: {favouriteCities.Count}");

            Console.Write("Favourite cities: ");
            foreach (var city in favouriteCities)
            {
                Console.Write($"{city}, ");
            }

            Console.WriteLine("");

            List<Student> students = new List<Student>()
            {
                new Student() {Id = 1, Name = "Adrian"},
                new Student() {Id = 2, Name = "Foo"},
                new Student() {Id = 3, Name = "Li"},
                new Student() {Id = 4, Name = "An"}
            };
            Console.WriteLine();

            Console.WriteLine($"Number of students: {students.Count}\n");

            Console.WriteLine("All students names: ");
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();

            List<Student> SortedStudents = students.OrderBy(s => s.Name).ToList();

            Console.WriteLine("Sorted list of students by name: ");
            foreach (Student s in SortedStudents)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine();

            //var result = from s in students
            //             where s.Name == "Foo"
            //             select s;

            // Why does it return false?
            Console.WriteLine(students.Contains(new Student { Id = 1 }));

        }
    }
}