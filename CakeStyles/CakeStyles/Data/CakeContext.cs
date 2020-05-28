using System;
using CakeStyles.Models;
using Microsoft.EntityFrameworkCore;
    

namespace CakeStyles.Data
{
    public class CakeContext : DbContext
    {
        public CakeContext(DbContextOptions<CakeContext> options)
            : base(options)
        {
        }
        public DbSet<Cake> Cake { get; set; }
    }
}
