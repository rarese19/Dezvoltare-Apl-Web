using Lab3_23.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab3_23.Data
{
    public class Lab3Context: DbContext
    {
        public DbSet<Masina> Masini { get; set; }
        public Lab3Context(DbContextOptions<Lab3Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
