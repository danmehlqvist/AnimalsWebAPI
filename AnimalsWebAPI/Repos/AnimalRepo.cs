using AnimalsWebAPI.Data;
using AnimalsWebAPI.Data.Entities;
using AnimalsWebAPI.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace AnimalsWebAPI.Repos
{
    public class AnimalRepo : IAnimalRepo
    {
        private readonly ApplicationContext _context;

        public AnimalRepo(ApplicationContext context)
        {
            this._context = context;
        }

        public Animal Create(CreateAnimalDTO animal)
        {
            Animal newAnimal = new Animal
            {
                Name = animal.Name,
                DateOfBirth = animal.DateOfBirth,
                AnimalTypeID = animal.AnimalTypeID,
            };

            _context.Animals.Add(newAnimal);
            _context.SaveChanges();
            return newAnimal;
        }

        public void Delete(Animal animal)
        {
            _context.Animals.Remove(animal);
            _context.SaveChanges();
        }

        public Animal Get(int id)
        {
             return _context
                .Animals
                .Include(a => a.AnimalType)
                .SingleOrDefault(x => x.ID == id);
        }

        public List<Animal> GetAll()
        {
            List<Animal> animals = _context
                .Animals
                .Include(a => a.AnimalType)
                .ToList();
            return animals;
        }

        public Animal Update(UpdateAnimalDTO animal)
        {
            Animal existingAnimal = _context
                .Animals
                .SingleOrDefault(x => x.ID == animal.ID);
            if (existingAnimal == null) return null;

            existingAnimal.AnimalTypeID = animal.AnimalTypeID;
            existingAnimal.DateOfBirth = animal.DateOfBirth;
            existingAnimal.Name = animal.Name;

            _context.SaveChanges();
            return existingAnimal;
        }
    }
}
