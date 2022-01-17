using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebContact.Domain.Models;
using WebContact.Resource;

namespace WebContact.Mapping
{
    public class ResourceToModelContact: Profile
    {
        public ResourceToModelContact()
        {
            CreateMap<SaveContactResource, Contact>();
           
        }
        
    }
}
