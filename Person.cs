using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public class Person
    {
        public string Name { get; set; }
        public string Homeworld { get; set; }

        public Person(string name, string homeworld)
        {
            Name = name;
            Homeworld = homeworld;
        }
    }
}
