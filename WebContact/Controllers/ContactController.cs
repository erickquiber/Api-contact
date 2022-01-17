
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebContact.Domain.Models;
using WebContact.Domain.Services;
using WebContact.Resource;

namespace WebContact.Controllers
{
    [Route("/api/[controller]")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;
        public  ContactController(IContactService contactService,IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<ContactResource>> GetAllAsync()
        {
            var contacts = await _contactService.ListAsync();
            var resources = _mapper
                .Map<IEnumerable<Contact>, IEnumerable<ContactResource>>(contacts);
            return resources;
        }
    }
}
