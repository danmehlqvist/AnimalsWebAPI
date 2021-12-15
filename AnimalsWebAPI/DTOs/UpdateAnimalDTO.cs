using System.ComponentModel.DataAnnotations;

namespace AnimalsWebAPI.DTOs
{
    public class UpdateAnimalDTO
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int AnimalTypeID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
