using System.ComponentModel.DataAnnotations;

namespace AnimalsWebAPI.DTOs
{
    public class CreateAnimalDTO
    {
        [Required]
        public int AnimalTypeID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
