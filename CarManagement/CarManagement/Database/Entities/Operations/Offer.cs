using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarManagement.Database.Entities
{
    public class Offer
    {
        [Key]
        public int OfferId { get; set; }
        [Required]
        public bool PaidMark { get; set; } = false;
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public int BuyerId { get; set; }
        [Required]
        public int CarId { get; set; }

        [ForeignKey("BuyerId")]
        public virtual Buyer Buyer { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }
    }
}