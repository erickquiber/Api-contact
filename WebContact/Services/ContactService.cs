using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebContact.Domain.Models;
using WebContact.Domain.Repositories;
using WebContact.Domain.Services;

namespace WebContact.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public  async Task<IEnumerable<Contact>> ListAsync()
        {
            return await _contactRepository.ListAsync();
        }
    }
}
