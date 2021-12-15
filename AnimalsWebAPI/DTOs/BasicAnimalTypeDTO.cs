using AnimalsWebAPI.Data.Entities;
using System.Linq;

namespace AnimalsWebAPI.DTOs
{
    public class BasicAnimalTypeDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
    }

    public static class BasicAnimalTypeDTOExtensions
    {
        public static BasicAnimalTypeDTO ToBasicAnimalTypeDTO(this AnimalType animal)
        {
            return new BasicAnimalTypeDTO
            {
                ID = animal.ID,
                Name = animal.Name,
                NumberOfLegs = animal.NumberOfLegs,
            };
        }

        public static List<BasicAnimalTypeDTO> ToBasicAnimalTypeDTOs(this List<AnimalType> animals)
        {
            return animals.Select(a => a.ToBasicAnimalTypeDTO()).ToList();
        }
    }

}
