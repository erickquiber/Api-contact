using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebContact.Domain.Models
{
    public class Contact:Person 
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
