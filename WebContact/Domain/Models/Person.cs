using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebContact.Domain.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UrlPhoto { get; set; }
    }
}
