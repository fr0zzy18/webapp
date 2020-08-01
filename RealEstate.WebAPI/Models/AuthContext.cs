using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RealEstate.WebAPI.Models
{
    public class AuthContext : IdentityDbContext
    {
        public AuthContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
