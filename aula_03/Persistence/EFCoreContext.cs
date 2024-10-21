<<<<<<< HEAD
using Aula03.Models;
using Microsoft.EntityFrameworkCore;

namespace Aula03.Persistence;

public class EFCoreContext : DbContext
{
    public EFCoreContext(DbContextOptions<EFCoreContext> options) : base(options)
    // public EFCoreContext( )
    {
        
    }

    public DbSet<CategoryModel>  Categories { get; set; }
    public DbSet<SupplierModel>  Suppliers { get; set; }
    public DbSet<ItemModel> Items { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlite("Data Source=../utfpr.db");

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
        .Entity<ItemModel>(
            eb =>
            {
                eb.HasKey(pk => pk.ItemID);
                eb.HasOne<CategoryModel>(i => i.Category)
                    .WithMany(c => c.Items)
                    .HasForeignKey(i => i.CategoryID);
                eb.HasOne<SupplierModel>(i => i.Supplier)
                    .WithMany(s => s.Items)
                    .HasForeignKey(i => i.SupplierID);
            });
    }
}
=======
using Aula03.Models;
using Microsoft.EntityFrameworkCore;

namespace Aula03.Persistence;

public class EFCoreContext : DbContext
{
    public EFCoreContext(DbContextOptions<EFCoreContext> options) : base(options)
    // public EFCoreContext( )
    {
        
    }

    public DbSet<CategoryModel>  Categories { get; set; }
    public DbSet<SupplierModel>  Suppliers { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder options)
    //     => options.UseSqlite("Data Source=../utfpr.db");

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
>>>>>>> origin/main
