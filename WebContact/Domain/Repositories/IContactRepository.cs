using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebContact.Domain.Models;

namespace WebContact.Domain.Repositories
{
    public interface IContactRepository
    {
        Task<IEnumerable<Contact>> ListAsync();
    }
}
