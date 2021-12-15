using System.ComponentModel.DataAnnotations;

namespace AnimalsWebAPI.Data.Entities
{
    public class BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public DateTime Created { get; set; } = DateTime.Now;

    }
}
