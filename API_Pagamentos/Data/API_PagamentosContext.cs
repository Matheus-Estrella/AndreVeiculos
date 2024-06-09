using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace API_Pagamentos.Data
{
    public class API_PagamentosContext : DbContext
    {
        public API_PagamentosContext (DbContextOptions<API_PagamentosContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Boleto> Boleto { get; set; } = default!;

        public DbSet<Models.Pagamento>? Pagamento { get; set; }

        public DbSet<Models.Pix>? Pix { get; set; }

        public DbSet<Models.TipoPix>? TipoPix { get; set; }
    }
}
