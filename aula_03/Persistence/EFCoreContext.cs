using Aula03.Models;
using Microsoft.EntityFrameworkCore;

namespace Aula03.Persistence;

public class EFCoreContext : DbContext
{
    public EFCoreContext(DbContextOptions<EFCoreContext> options) : base(options)
    //public EFCoreContext( )
    {
        
    }

    public DbSet<CategoryModel>  Categories { get; set; }
    public DbSet<SupplierModel>  Suppliers { get; set; }
    public DbSet<UnitOfMeasureModel> UnitsOfMeasure { get; set; }

    //   protected override void OnConfiguring(DbContextOptionsBuilder options)
    //       => options.UseSqlite("Data Source=../utfpr.db");

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
        modelBuilder
        .Entity<UnitOfMeasureModel>(
            eb =>
            {
                eb.HasKey(pk => pk.UnitOfMeasureID);
            });
    }
}
