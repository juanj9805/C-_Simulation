using Microsoft.EntityFrameworkCore;
using simulacro.Models;

namespace simulacro.Data;

public class MySqlDbContext : DbContext
{
    public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
    {
    }

    public DbSet<Owner> owners { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Owner>(owner =>
        {
            owner.Property(owner => owner.Name).IsRequired().HasMaxLength(45);
        });
    }
}