using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4guys_bs.Models;
using Microsoft.EntityFrameworkCore;

namespace _4guys_bs.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> DbUsers {get; set;}
    }
}