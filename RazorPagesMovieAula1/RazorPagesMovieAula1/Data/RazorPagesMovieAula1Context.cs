using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovieAula1.Models;

namespace RazorPagesMovieAula1.Data
{
    public class RazorPagesMovieAula1Context : DbContext
    {
        public RazorPagesMovieAula1Context (DbContextOptions<RazorPagesMovieAula1Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovieAula1.Models.Movie> Movie { get; set; }

        public DbSet<RazorPagesMovieAula1.Models.Diretor> Diretor { get; set; }
    }
}
