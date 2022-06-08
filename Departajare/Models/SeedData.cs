using Departajare.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Departajare.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DepartajareContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DepartajareContext>>()))
            {
                if(!context.Review.Any())
                {
                    context.Review.AddRange(
                    new Review
                    {
                        UserName = "Mark",
                        DatePublished = DateTime.Parse("2020-05-07"),
                        ReviewText = "Nice movie!",
                        MovieId = 1
                    },

                    new Review
                    {
                        UserName = "John",
                        DatePublished = DateTime.Parse("2021-07-07"),
                        ReviewText = "Nice movie!",
                        MovieId = 2
                    }
                    );
                }

                // Look for any movies.
                if (!context.Movie.Any())
                {

                    context.Movie.AddRange(
                        new Movie
                        {
                            Title = "When Harry Met Sally",
                            ReleaseDate = DateTime.Parse("1989-2-12"),
                            Genre = "Romantic Comedy",
                            Price = 7.99M
                        },

                        new Movie
                        {
                            Title = "Ghostbusters ",
                            ReleaseDate = DateTime.Parse("1984-3-13"),
                            Genre = "Comedy",
                            Price = 8.99M
                        },

                        new Movie
                        {
                            Title = "Ghostbusters 2",
                            ReleaseDate = DateTime.Parse("1986-2-23"),
                            Genre = "Comedy",
                            Price = 9.99M
                        },

                        new Movie
                        {
                            Title = "Rio Bravo",
                            ReleaseDate = DateTime.Parse("1959-4-15"),
                            Genre = "Western",
                            Price = 3.99M
                        }
                    );
                }

                if (!context.VideoGame.Any())
                {
                    context.VideoGame.AddRange(
                    new VideoGame
                    {
                        Title = "Farcry",
                        ReleaseDate = DateTime.Parse("2004-3-23"),
                        Genre = "Action",
                        Price = 2.99M
                    },

                    new VideoGame
                    {
                        Title = "Sims",
                        ReleaseDate = DateTime.Parse("2000-2-4"),
                        Genre = "Life Simulation",
                        Price = 2.99M
                    }
                    );
                }
                context.SaveChanges();
            }
        }
    }
}
