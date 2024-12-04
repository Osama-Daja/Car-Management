using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarManagement.Database.Entities
{
    public class Car
    {
        public Car()
        {
            Offers = new HashSet<Offer>();
            CarHistories = new HashSet<CarHistory>();
        }
        [Key]
        public int CarId { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int SubmodelId { get; set; }
        [Required]
        public int LocationId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("SubmodelId")]
        public virtual Submodel Submodel { get; set; }
        [ForeignKey("LocationId")]
        public virtual Location Location { get; set; }

        public ICollection<Offer> Offers { get; set; }
        public ICollection<CarHistory> CarHistories { get; set; }
    }
}