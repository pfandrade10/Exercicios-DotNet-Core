using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovieAula1.Data;
using RazorPagesMovieAula1.Models;

namespace RazorPagesMovieAula1.Pages.Directors
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMovieAula1.Data.RazorPagesMovieAula1Context _context;

        public CreateModel(RazorPagesMovieAula1.Data.RazorPagesMovieAula1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Diretor Diretor { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Diretor.Add(Diretor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
