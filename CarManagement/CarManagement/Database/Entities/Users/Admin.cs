using System.ComponentModel.DataAnnotations;

namespace CarManagement.Database.Entities
{
    public class Admin : UserBase
    {
        public Admin()
        {
            CarHistories = new HashSet<CarHistory>();
        }
        [Key]
        public int AdminId { get; set; }

        public ICollection<CarHistory> CarHistories { get; set; }
    }
}