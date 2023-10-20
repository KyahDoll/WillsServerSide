using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace API
{
    public class People
    {
        public Person[] Results { get; set; }

        public People(Person[] results) 
        {
            Results = results;
        }
    }
}