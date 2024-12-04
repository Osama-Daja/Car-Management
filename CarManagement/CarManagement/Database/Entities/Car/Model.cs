using System.ComponentModel.DataAnnotations;

namespace CarManagement.Database.Entities
{
    public class Model
    {
        public Model()
        {
            Submodels = new HashSet<Submodel>();
        }
        [Key]
        public int ModelId { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Submodel> Submodels { get; set; }
    }
}