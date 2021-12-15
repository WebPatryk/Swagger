using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Swagger.Models;

namespace Swagger.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TodoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TodoContext>>()))
            {
                // Look for any movies.
                if (context.TodoItems.Any())
                {
                    return;   // DB has been seeded
                }

                context.TodoItems.AddRange(
                    new TodoItem
                    {
                        Title = "Star Wars",
                        ReleaseDate = DateTime.Parse("1995-5-10"),
                        Rate = 4,
                        TickekPrice = 150.99M
                    },

                    new TodoItem
                    {
                        Title = "Need For Speed",
                        ReleaseDate = DateTime.Parse("2005-11-25"),
                        Rate = 5,
                        TickekPrice = 58.50M
                    },

                    new TodoItem
                    {
                        Title = "Grand Theft Auto V",
                        ReleaseDate = DateTime.Parse("2013-05-10"),
                        Rate = 5,
                        TickekPrice = 320.10M
                    },

                    new TodoItem
                    {
                        Title = "Far Cry 3",
                        ReleaseDate = DateTime.Parse("2011-01-26"),
                        Rate = 3,
                        TickekPrice = 45.50M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}