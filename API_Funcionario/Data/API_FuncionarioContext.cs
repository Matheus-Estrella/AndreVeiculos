using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace API_Funcionario.Data
{
    public class API_FuncionarioContext : DbContext
    {
        public API_FuncionarioContext (DbContextOptions<API_FuncionarioContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configura a chave primária na entidade raiz Pessoa
            modelBuilder.Entity<Pessoa>()
                .HasKey(p => p.Documento);
        }
        public DbSet<Models.Funcionario> Funcionario { get; set; } = default!;

        public DbSet<Models.Cargo>? Cargo { get; set; }
    }
}
