using System.Collections;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company c = new Company();
            foreach (var employee in c)
            {
                Console.WriteLine(employee);
            }
        }

        class LegalEntity
        {
            public string Name { get; set; }
        }

        class Company : LegalEntity, IEnumerable
        {
            public Company()
            {
                Employees = new List<string>
                {
                    "Bo", "Li", "An"
                };
            }
            public DateTime RegistrationDate { get; set; }
            public List<string> Employees { get; set; }

            public IEnumerator GetEnumerator()
            {
                return Employees.GetEnumerator();
            }
        }
    }
}