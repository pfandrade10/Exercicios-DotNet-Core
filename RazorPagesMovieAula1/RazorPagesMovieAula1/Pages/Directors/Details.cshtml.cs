﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovieAula1.Data.RazorPagesMovieAula1Context _context;

        public DetailsModel(RazorPagesMovieAula1.Data.RazorPagesMovieAula1Context context)
        {
            _context = context;
        }

        public Diretor Diretor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Diretor = await _context.Diretor.FirstOrDefaultAsync(m => m.ID == id);

            if (Diretor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
