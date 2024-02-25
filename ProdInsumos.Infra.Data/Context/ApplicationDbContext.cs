using Microsoft.EntityFrameworkCore;
using ProdInsumos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdInsumos.Infra.Data.Context
{
    public   class ApplicationDbContext : DbContext
    {
        public  ApplicationDbContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Funcionario> Funcionario { get; set; }

        public DbSet<Computador> Computador { get; set; }

        public DbSet<Alocado> Alocado { get; set; }


        protected override void OnModelCreating(ModelBuilder builder) 
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        
        }
    }
}
