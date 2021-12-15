using AnimalsWebAPI.Data.Entities;

namespace AnimalsWebAPI.DTOs
{
    public class AnimalDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public BasicAnimalTypeDTO AnimalType { get; set; }
    }

    public static class AnimalDTOExtensions
    {
        public static AnimalDTO ToAnimalDTO(this Animal animal)
        {
            return new AnimalDTO
            {
                ID = animal.ID,
                Name = animal.Name,
                DateOfBirth = animal.DateOfBirth,
                AnimalType = animal.AnimalType.ToBasicAnimalTypeDTO(),
            };
        }

        public static List<AnimalDTO> ToAnimalDTOs(this List<Animal> animals)
        {
            return animals.Select(a => a.ToAnimalDTO()).ToList();
        }
    }
}


