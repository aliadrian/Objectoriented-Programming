using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime NameDay { get; set; }

        public Person(string name, DateTime nameDay)
        {
            Name = name;
            NameDay = nameDay;
        }
    }
}
