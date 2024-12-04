using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarManagement.Database.Entities
{
    public class CarHistory
    {
        [Key]
        public int CarHistoryId { get; set; }

        [Required]
        public string Status { get; set; }
        [Required]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        [Required]
        public int AdminId { get; set; }
        [Required]
        public int CarId { get; set; }

        [ForeignKey("AdminId")]
        public virtual Admin Admin { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }
    }
}