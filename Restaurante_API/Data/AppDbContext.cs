using Microsoft.EntityFrameworkCore;
using Restaurante_API.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Restaurante_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Restaurantes> Restaurantes { get; set; }
        public DbSet<Pratos> Pratos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pratos>()
                .Property(p => p.Preco)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
