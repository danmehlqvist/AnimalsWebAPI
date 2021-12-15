using AnimalsWebAPI.Classes;
using AnimalsWebAPI.Data.Entities;
using AnimalsWebAPI.DTOs;

namespace AnimalsWebAPI.Repos
{
    public interface IAnimalRepo
    {
        PaginatedResult<AnimalDTO> GetAll(int currentPage, int itemsPerPage);

        Animal Get(int id);

        void Delete(Animal animal);

        Animal Create(CreateAnimalDTO animal);

        Animal Update(UpdateAnimalDTO animal);
    }
}
