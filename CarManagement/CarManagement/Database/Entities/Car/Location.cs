using System.ComponentModel.DataAnnotations;

namespace CarManagement.Database.Entities
{
    public class Location
    {
        public Location()
        {
            Cars = new HashSet<Car>();
        }
        [Key]
        public int LocationId { get; set; }
        [Required]
        public string Zipcode { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
