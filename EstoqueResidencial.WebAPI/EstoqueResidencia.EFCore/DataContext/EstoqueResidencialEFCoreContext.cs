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
    public DbSet<SupplierModel>  Suppliers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=../EstoqueResidencia.EFCore/utfpr.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder
        .Entity<CategoryModel>(
            eb =>
            {
                eb.HasKey(pk => pk.CategoryID);
            });
        modelBuilder
        .Entity<SupplierModel>(
            eb =>
            {
                eb.HasKey(pk => pk.SupplierID);
            });
    }
}
