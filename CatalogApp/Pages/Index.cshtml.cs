using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CatalogApp.Data;
using CatalogApp.Models;

namespace CatalogApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CatalogApp.Data.CatalogAppContext _context;

        public IndexModel(CatalogApp.Data.CatalogAppContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Person.ToListAsync();
        }
    }
}
