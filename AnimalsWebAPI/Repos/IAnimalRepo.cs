using AnimalsWebAPI.Data.Entities;
using AnimalsWebAPI.DTOs;

namespace AnimalsWebAPI.Repos
{
    public interface IAnimalRepo
    {
        List<Animal> GetAll();

        Animal Get(int id);

        void Delete(Animal animal);

        Animal Create(CreateAnimalDTO animal);

        Animal Update(UpdateAnimalDTO animal);
    }
}
