namespace Assignment1;

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext (DbContextOptions<AppDbContext> options)
        : base(options) {}

    public DbSet<Country> Countries {get; set;}
}
