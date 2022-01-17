using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebContact.Domain.Models;

namespace WebContact.Resource
{
    public class ContactResource:Person
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
