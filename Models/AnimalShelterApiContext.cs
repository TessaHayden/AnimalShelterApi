using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : IdentityDbContext<IdentityUser>
  {
    public DbSet<Animal> Animals { get; set; }
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
      .HasData(
        new Animal { AnimalId = 1, Name = "Lucifer", Species = "Dog", Age = 1 }
      );
    }
  }
}