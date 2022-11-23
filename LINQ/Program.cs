using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        private const string Path = @"C:\Users\AliNasrat\source\repos\Objectoriented Programming\LINQ\names.csv";
        private static void Main(string[] args)
        {
            var query = File.ReadAllLines(Path, System.Text.Encoding.Latin1)
                .Distinct()
                .Select(x => x.Split(';'))
                .Select(x => new Person(x[0], DateTime.Parse(x[1])))
                .ToList();

            //ListAllNamesThatBeginsWithAn(query, "an");
            ListNameWithNamnsdagSpecificDate(query, 12, 21);
        }

        private static void ListNameWithNamnsdagSpecificDate(List<Person> query2, int month, int day)
        {
            var q2 = query2
                .Where(x => x.NameDay.Month == month && x.NameDay.Day == day)
                .ToList();

            foreach (var nameDay in q2)
            {
                Console.WriteLine(nameDay);
            }
        }

        private static void ListAllNamesThatBeginsWithAn(List<Person> query1, string s)
        {
            var q = query1
              .Where(x => x.Name.ToLower().StartsWith(s.ToLower()))
              .Select(x => x.Name)
              .ToList();

            foreach (var personName in q)
            {
                Console.WriteLine(personName);
            }
        }
    }
}