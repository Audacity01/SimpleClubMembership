using ClubMembershipApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication.Data
{
    public class ClubMembershipDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Enter SQL Server conn string");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}
