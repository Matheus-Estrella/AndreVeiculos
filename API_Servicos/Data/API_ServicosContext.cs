using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace API_Servicos.Data
{
    public class API_ServicosContext : DbContext
    {
        public API_ServicosContext (DbContextOptions<API_ServicosContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Servico> Servico { get; set; } = default!;
    }
}
