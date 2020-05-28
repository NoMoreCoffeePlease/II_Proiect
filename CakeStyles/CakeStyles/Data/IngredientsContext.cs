using System;
using CakeStyles.Models;
using Microsoft.EntityFrameworkCore;

namespace CakeStyles.Data
{
    public class IngredientsContext: DbContext
    {
        public IngredientsContext (DbContextOptions<IngredientsContext> options)
            : base(options)
        {
        }

        public DbSet<Ingredients> Ingredients { get; set; }
    }
}
