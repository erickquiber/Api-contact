using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebContact.Domain.Models;

namespace WebContact.Resource
{
    public class SaveContactResource:Person
    {
        [Required]
        public string Email { get; set; }
        [MaxLength(25)]
        public string Phone { get; set; }
    }
}
