using Microsoft.EntityFrameworkCore;
using simulacro.Models;

namespace simulacro.Data;

public class MySqlDbContext : DbContext
{
    public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
    {
    }

    public DbSet<Owner> owners { get; set; }
    public DbSet<Pet> pets { get; set; }
    public DbSet<Consultation> consultations { get; set; }
    public DbSet<Veterinary> veterinaries { get; set; }
    public DbSet<Treatment> treatments { get; set; }
    public DbSet<Medicine> medicines { get; set; }
    public DbSet<TreatmentMedicine> treatmentsMedicines { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Owner>(owner =>
        {
            owner.Property(ow => ow.Name).IsRequired().HasMaxLength(45);
            owner.Property(ow => ow.Phone).IsRequired().HasMaxLength(45);

            owner.HasMany<Pet>(ow => ow.Pets).WithOne(pet => pet.Owner).HasForeignKey(pet => pet.OwnerId).OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Pet>(pet =>
        {
            pet.Property(p => p.Name).IsRequired().HasMaxLength(45);
            pet.Property(p => p.Breed).IsRequired();
            pet.Property(p => p.Age).IsRequired();
            pet.Property(p => p.OwnerId).IsRequired();
        });

        modelBuilder.Entity<Consultation>(consultation =>
        {
            consultation.Property(con => con.PetId).IsRequired();
            consultation.Property(con => con.VeterinaryId).IsRequired();
            consultation.Property(con => con.Reason).IsRequired().HasMaxLength(45);
            
        });
    }
}