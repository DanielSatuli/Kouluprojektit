using Microsoft.EntityFrameworkCore;
using ItemApi.Data;
using System;
using System.Linq;

namespace ItemApi.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ItemContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ItemContext>>()))
            {
                context.Database.EnsureCreated();

                if (context.Items.Any())
                {
                    return;   // DB has been seeded
                }

                context.Items.AddRange(
                    new Item
                    {
                        Error = "Saumavika",
                        Description = "0.02mm heitto kohdassa 2",
                        When = new DateTime(2023, 2, 1, 7, 0, 0)
                    },
                    new Item
                    {
                        Error = "Saumavika",
                        Description = "0.01mm heitto kohdassa 25",
                        When = new DateTime(2023, 2, 2, 14, 0, 0)
                    },
                    new Item
                    {
                        Error = "Saumavika",
                        Description = "0.04mm heitto kohdassa 10",
                        When = new DateTime(2023, 2, 3, 8, 0, 0)
                    },
                    new Item
                    {
                        Error = "Saumavika",
                        Description = "0.05mm heitto kohdassa 8",
                        When = new DateTime(2023, 2, 4, 9, 0, 0)
                    },
                    new Item
                    {
                        Error = "Saumavika",
                        Description = "0.07mm heitto kohdassa 30",
                        When = new DateTime(2023, 2, 5, 15, 0, 0)
                    });

                context.SaveChanges();
            }
        }
    }
}
