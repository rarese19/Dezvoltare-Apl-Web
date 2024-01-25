using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data;

public class DatabaseContext: DbContext
{
    public DbSet<Profesor> Profesori { get; set; }
    public DbSet<Materie> Materii { get; set; }
    public DbSet<ProfesorMaterie> ProfesoriMaterii {  get; set; }
    
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ProfesorMaterie>()
            .HasOne(p => p.Profesor)
            .WithMany(p => p.ProfesorMaterie)
            .HasForeignKey(p => p.ProfesorId);

        modelBuilder.Entity<ProfesorMaterie>()
            .HasOne(m => m.Materie)
            .WithMany(m => m.ProfesorMaterie)
            .HasForeignKey(m => m.MaterieId);
    }
}