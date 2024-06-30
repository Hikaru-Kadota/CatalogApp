using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CatalogApp.Models;

namespace CatalogApp.Data
{
    public class CatalogAppContext : DbContext
    {
        public CatalogAppContext (DbContextOptions<CatalogAppContext> options)
            : base(options)
        {
        }

        public DbSet<CatalogApp.Models.Person> Person { get; set; } = default!;
    }
}
