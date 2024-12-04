using System.ComponentModel.DataAnnotations;

namespace CarManagement.Database.Entities
{
    public class Buyer : UserBase
    {
        public Buyer()
        {
            Offers = new HashSet<Offer>();
        }
        [Key]
        public int BuyerId { get; set; }

        public ICollection<Offer> Offers { get; set; }
    }
}