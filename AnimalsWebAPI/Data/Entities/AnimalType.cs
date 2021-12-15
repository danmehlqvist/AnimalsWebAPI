using System.ComponentModel.DataAnnotations;

namespace AnimalsWebAPI.Data.Entities
{
    public class AnimalType: BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int NumberOfLegs { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }

        public AnimalType()
        {
            Animals = new List<Animal>();
        }
    }
}
