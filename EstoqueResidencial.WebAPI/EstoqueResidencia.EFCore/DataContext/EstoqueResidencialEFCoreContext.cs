using EstoqueResidencial.Model.Model;
using Microsoft.EntityFrameworkCore;

namespace EstoqueResidencia.EFCore.DataContext;

public class EstoqueResidencialEFCoreContext : DbContext
{
    public EstoqueResidencialEFCoreContext(DbContextOptions<EstoqueResidencialEFCoreContext> options) : base(options)
    // public EstoqueResidencialEFCoreContext( )
    {
        
    }

    public DbSet<CategoryModel>  Categories { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder options)
    //     => options.UseSqlite($"Data Source=./utfpr.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder
        .Entity<CategoryModel>(
            eb =>
            {
                eb.HasKey(pk => pk.CategoryID);
            });
    }
}
