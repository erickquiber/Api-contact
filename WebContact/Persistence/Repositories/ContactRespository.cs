using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebContact.Domain.Models;
using WebContact.Domain.Repositories;
using WebContact.Domain.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace WebContact.Persistence.Repositories
{
    public class ContactRespository : BaseRepository, IContactRepository
    {
        public ContactRespository(AppDbContext context) : base(context) { }
        public async Task<IEnumerable<Contact>> ListAsync()
        {
            return await _context.contacts.ToListAsync();
        }
    }
}
