using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace API_Compra.Data
{
    public class API_CompraContext : DbContext
    {
        public API_CompraContext (DbContextOptions<API_CompraContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Compra> Compra { get; set; } = default!;
    }
}
