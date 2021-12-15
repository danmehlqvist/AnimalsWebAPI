using AnimalsWebAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;

// dotnet ef migrations add XXX



namespace AnimalsWebAPI.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalType> AnimalTypes { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimalType>().HasData(
                new AnimalType
                {
                    ID=1,
                    Name="Dog",
                    NumberOfLegs=4
                },
                new AnimalType
                {
                    ID = 2,
                    Name = "Ostrich",
                    NumberOfLegs = 2
                },
                new AnimalType
                {
                    ID = 3,
                    Name = "Spider",
                    NumberOfLegs = 8
                });

            modelBuilder.Entity<Animal>().HasData(
                new Animal
                {
                    ID = 1,
                    Name = "Adam",
                    DateOfBirth = new DateTime(1975, 1, 7),
                    AnimalTypeID = 1,
                },
                new Animal
                {
                    ID = 2,
                    Name = "Benke",
                    DateOfBirth = new DateTime(1975, 1, 7),
                    AnimalTypeID = 2,
                },
                new Animal
                {
                    ID = 3,
                    Name = "Camilla",
                    DateOfBirth = new DateTime(1975, 1, 7),
                    AnimalTypeID = 3,
                },
                new Animal
                {
                    ID = 4,
                    Name = "Daniela",
                    DateOfBirth = new DateTime(1975, 1, 7),
                    AnimalTypeID = 3,
                });
        }
    }
}
