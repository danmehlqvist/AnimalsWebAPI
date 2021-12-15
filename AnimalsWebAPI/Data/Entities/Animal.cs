using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalsWebAPI.Data.Entities
{
    public class Animal : BaseEntity
    {
        [ForeignKey("AnimalType")]
        public int AnimalTypeID { get; set; }

        public AnimalType AnimalType { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
