using System;
using Microsoft.EntityFrameworkCore;
using CakeStyles.Models;

namespace CakeStyles.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }
        public DbSet<User> User { get; set; }
    }
}
