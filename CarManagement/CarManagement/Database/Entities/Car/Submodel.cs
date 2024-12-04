using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarManagement.Database.Entities
{
    public class Submodel
    {
        public Submodel()
        {
            Cars = new HashSet<Car>();
        }
        [Key]
        public int SubmodelId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public int ModelId { get; set; }
        [ForeignKey("ModelId")]
        public virtual Model Model { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
