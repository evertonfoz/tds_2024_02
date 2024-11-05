namespace BackendDotNet.Persistence.Data;

using BackendDotNet.Models.Models;
using Microsoft.EntityFrameworkCore;

public class EFCoreContext : DbContext
{
    public EFCoreContext(DbContextOptions<EFCoreContext> options) : base(options)
    {
        
    }

    public DbSet<CategoryEntity>  Categories { get; set; }

}
