using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace API_Cliente.Data
{
    public class API_ClienteContext : DbContext
    {
        public API_ClienteContext (DbContextOptions<API_ClienteContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Cliente> Cliente { get; set; } = default!;
    }
}
