using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCLdsMovies.Models
{
    public class MVCLdsMoviesContext : DbContext
    {
        public MVCLdsMoviesContext (DbContextOptions<MVCLdsMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<MVCLdsMovies.Models.Movie> Movie { get; set; }
    }
}
