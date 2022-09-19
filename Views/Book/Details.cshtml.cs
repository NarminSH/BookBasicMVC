using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookCatalog.Data;
using BookCatalog.Models;

namespace BookCatalog.Views.Book
{
    public class DetailsModel : PageModel
    {
        private readonly BookCatalog.Data.BookContext _context;

        public DetailsModel(BookCatalog.Data.BookContext context)
        {
            _context = context;
        }

        public BookCatalog.Models.Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.Id == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
