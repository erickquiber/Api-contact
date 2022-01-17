using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebContact.Domain.Models;

namespace WebContact.Domain.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Contact> contacts { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //Contact
            builder.Entity<Contact>().ToTable("Contacts");
            builder.Entity<Contact>().HasKey(p => p.Id);
            builder.Entity<Contact>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Contact>().Property(p => p.Email).IsRequired();
            builder.Entity<Contact>().Property(p => p.Name).IsRequired().HasMaxLength(30);

            builder.Entity<Contact>().HasData
                (
                 new Contact {Id=100,Name="Erick",LastName="Quispe Bernardo",Email="erickquiber@gmail.com",Phone="985715927",Age=26 },
                 new Contact { Id = 101, Name = "Simon", LastName = "Paredes", Email = "simon@gmail.com", Phone = "985747927", Age = 65 },
                 new Contact { Id = 102, Name = "Maria", LastName = "Rodriguez", Email = "maria@gmail.com", Phone = "985716927", Age = 70 },
                 new Contact { Id = 103, Name = "Juan", LastName = "Flores", Email = "juan@gmail.com", Phone = "985716927", Age = 45},
                 new Contact { Id = 104, Name = "Paolo", LastName = "Guerrero", Email = "paolo9@gmail.com", Phone = "985716929", Age = 36 },
                 new Contact { Id = 105, Name = "Agustin", LastName = "Farfan", Email = "farfan17@gmail.com", Phone = "985716935", Age = 35 },
                 new Contact { Id = 106, Name = "Percy", LastName = "Misterio", Email = "crema@gmail.com", Phone = "985716942", Age = 45 },
                 new Contact { Id = 107, Name = "Jose", LastName = "Cruz", Email = "josue666@gmail.com", Phone = "975716927", Age = 16 },
                 new Contact { Id = 108, Name = "Pablo", LastName = "Quesada", Email = "pablo89@gmail.com", Phone = "962716927", Age = 32 },
                 new Contact { Id = 109, Name = "Thomas", LastName = "Conejo", Email = "thomas57@gmail.com", Phone = "985916927", Age = 41 },
                 new Contact { Id = 110, Name = "Brayan", LastName = "Zapata", Email = "brayan105@gmail.com", Phone = "999716927", Age = 22 },
                 new Contact { Id = 111, Name = "Raul", LastName = "Morales", Email = "raul77@gmail.com", Phone = "999916927", Age = 25}
                );

           


        }

    }
}
