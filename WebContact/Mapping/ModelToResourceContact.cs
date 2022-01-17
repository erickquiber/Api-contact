using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebContact.Domain.Models;
using WebContact.Resource;

namespace WebContact.Mapping
{
    public class ModelToResourceContact:Profile
    {
        public ModelToResourceContact()
        {
            CreateMap<Contact, ContactResource>();
            
        }
        
    }
}
