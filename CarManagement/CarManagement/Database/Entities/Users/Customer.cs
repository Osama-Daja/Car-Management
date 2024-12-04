using System.ComponentModel.DataAnnotations;

namespace CarManagement.Database.Entities
{
    public class Customer : UserBase
    {
        public Customer()
        {
            Cars = new HashSet<Car>();
        }
        [Key]
        public int CustomerId { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}