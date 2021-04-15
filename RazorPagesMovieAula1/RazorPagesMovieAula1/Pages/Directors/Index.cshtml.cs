using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovieAula1.Data;
using RazorPagesMovieAula1.Models;

namespace RazorPagesMovieAula1.Pages.Directors
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieAula1.Data.RazorPagesMovieAula1Context _context;

        public IndexModel(RazorPagesMovieAula1.Data.RazorPagesMovieAula1Context context)
        {
            _context = context;
        }

        public IList<Diretor> Diretor { get;set; }

        public async Task OnGetAsync()
        {
            Diretor = await _context.Diretor.ToListAsync();
        }
    }
}
