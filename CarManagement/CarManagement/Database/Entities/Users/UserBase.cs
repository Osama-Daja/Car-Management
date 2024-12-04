using System.ComponentModel.DataAnnotations;

namespace CarManagement.Database.Entities
{
    public class UserBase
    {
        [Required]
        public string Name { get; set; }
    }
}
