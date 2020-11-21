using Microsoft.EntityFrameworkCore;
using RefreshToken_Vaqueiro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefreshToken_Vaqueiro.Helpers
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        }
        public DbSet<LoginUser> LoginModels { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginUser>().HasData(new LoginUser
            {
                Id = 2,
                UserName = "Ignacio@hotmail.com",
                Password = "ignacio123"
            });
        }
    }
}
