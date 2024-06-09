using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace API_Endereco.Data
{
    public class API_EnderecoContext : DbContext
    {
        public API_EnderecoContext (DbContextOptions<API_EnderecoContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Endereco> Endereco { get; set; } = default!;
    }
}
