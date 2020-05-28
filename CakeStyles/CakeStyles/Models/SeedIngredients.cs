using System;
using CakeStyles.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
namespace CakeStyles.Models

{
    public class SeedIngredients
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new IngredientsContext(
                serviceProvider.GetRequiredService<DbContextOptions<IngredientsContext>>()))
            {
                //Look for any cakes
                if (context.Ingredients.Any())
                {
                    return; //DB has been seeded
                }

                context.Ingredients.AddRange(
                    new Ingredients
                    {
                        IngredientsUsed = "lapte oua miere",
                        Calories = 200
                    },
                    new Ingredients
                    {
                        IngredientsUsed = "ciocolata oua faina",
                        Calories = 150 
                    }
                    );
                context.SaveChanges();
            }

        }
    }
}
