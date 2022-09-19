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
    public class IndexModel : PageModel
    {
        private readonly BookCatalog.Data.BookContext _context;

        public IndexModel(BookCatalog.Data.BookContext context)
        {
            _context = context;
        }

        public IList<BookCatalog.Models.Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
