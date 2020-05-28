using System;
using CakeStyles.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
namespace CakeStyles.Models

{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CakeContext(
                serviceProvider.GetRequiredService<DbContextOptions<CakeContext>>()))
            {
                //Look for any cakes
                if (context.Cake.Any())
                {
                    return; //DB has been seeded
                }

                context.Cake.AddRange(
                    new Cake
                    {
                        Title = "Albinuta",
                        Description = "A Romanian traditional cake filled with honey and soft pandispan",
                        Price = 45
                    },
                    new Cake
                    {
                        Title = "Krantz",
                        Description = "Krantz is Romanian traditional cake. It's filled with hazelnuts and has a chocolate cream",
                        Price = 50
                    }
                    ) ;
                context.SaveChanges();
            }
                
        }
    }
}
