using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Person : IEqualityComparer<Person>
    {
        public string Name { get; set; }
        public DateTime NameDay { get; set; }

        public Person(string name, DateTime nameDay)
        {
            Name = name;
            NameDay = nameDay;
        }

        //public static Person ConvertStringToPerson(string s)
        //{
        //    string[] info = s.Split(';');
        //    return new Person(info[0], DateTime.Parse(info[1]));
        //}

        //public override string ToString()
        //{
        //    if (Name.Length > 7)
        //        return $"{Name}\t{NameDay.ToShortDateString()}";
        //    else
        //        return $"{Name}\t\t{NameDay.ToShortDateString()}";
        //}

        //public bool Equals(Person x, Person y)
        //{
        //    return x.Name == y.Name;
        //}

        //public int GetHashCode([DisallowNull] Person obj)
        //{
        //    return obj.Name.GetHashCode() + obj.NameDay.GetHashCode();
        //}
    }
}
