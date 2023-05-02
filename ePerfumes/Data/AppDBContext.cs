using ePerfumes.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ePerfumes.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marca>()
                .HasMany<Perfume>(m=>m.Perfumes)
                .WithOne(m=>m.Marca)
                .HasForeignKey(m=>m.Marca_ID);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Perfume> Perfumes { get; set; }
    }
}
