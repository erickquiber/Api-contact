using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebContact.Domain.Models;

namespace WebContact.Domain.Services
{
    public interface IContactService
    {
        Task<IEnumerable<Contact>> ListAsync();
    }
}
