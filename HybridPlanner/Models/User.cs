using System.ComponentModel.DataAnnotations;

namespace HybridPlanner.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string EmailAdress { get; set; }
        public int? LocationId { get; set; }
        public Location? Location { get; set; }
    }
}
