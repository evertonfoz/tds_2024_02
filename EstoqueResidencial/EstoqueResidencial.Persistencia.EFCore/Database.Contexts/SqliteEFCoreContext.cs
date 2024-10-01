
using EstoqueResidencial.Modelo.Basicas;
using Microsoft.EntityFrameworkCore;

namespace EstoqueResidencial.Persistencia.EFCore.Database.Contexts;

public class SqliteEFCoreContext : DbContext
{

    // public SqliteEFCoreContext(DbContextOptions<SqliteEFCoreContext> options) : base(options)
    // {}

    public DbSet<CategoriaModelo> Categorias {get;set;}

    // public string DbPath { get; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source=/Users/evertoncoimbradearaujo/Documents/GitHub/tds_2024_02/EstoqueResidencial/EstoqueResidencial.Persistencia.EFCore/utfpr.db");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder
        .Entity<CategoriaModelo>(
            eb =>
            {
                eb.HasKey(pk => pk.CategoriaID);
            });
    }
}
