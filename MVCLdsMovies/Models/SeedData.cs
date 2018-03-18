using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MVCLdsMovies.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCLdsMoviesContext(
                serviceProvider.GetRequiredService<DbContextOptions<MVCLdsMoviesContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "The Work and the Glory",
                         ReleaseDate = DateTime.Parse("2004-11-24"),
                         Genre = "Documentary",
                         Price = 11.99M,
                         Rating = "PG"
                     },

                     new Movie
                     {
                         Title = "Meet The Mormons",
                         ReleaseDate = DateTime.Parse("2014-10-11"),
                         Genre = "Documentary",
                         Price = 9.99M,
                         Rating = "PG"
                     },

                     new Movie
                     {
                         Title = "The Saratov Approach",
                         ReleaseDate = DateTime.Parse("2013-10-20"),
                         Genre = "Drama/Action",
                         Price = 9.99M,
                         Rating = "PG"
                     },

                   new Movie
                   {
                       Title = "17 Miracles",
                       ReleaseDate = DateTime.Parse("2011-6-3"),
                       Genre = "History/Adventure",
                       Price = 10.16M,
                       Rating = "PG"
                   }
                );
                context.SaveChanges();
            }
        }
    }
}