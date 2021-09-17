using CursoEFCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoEFCore.Data
{
    class ApplicationContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = CursoEFCore; Integrated Security = True; Connect Timeout = 30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);

        }
    }
}
