using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace API_ServicoCarro.Data
{
    public class API_ServicoCarroContext : DbContext
    {
        public API_ServicoCarroContext (DbContextOptions<API_ServicoCarroContext> options)
            : base(options)
        {
        }

        public DbSet<Models.CarroServico> CarroServico { get; set; } = default!;
    }
}
