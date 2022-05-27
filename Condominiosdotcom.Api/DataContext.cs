using Condominiosdotcom.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api
{
    public class DataContext:DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Condominio> Condominio { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Cuotas> Cuotas { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<Residencial> Residencial { get; set; }
        public DbSet<Concepto> Concepto { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }

    }
}
