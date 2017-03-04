using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Models
{
    public class PersonDbContext : DbContext
    {   
        public PersonDbContext(DbContextOptions<PersonDbContext> options)
            : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}
