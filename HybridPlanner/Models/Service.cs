using System.ComponentModel.DataAnnotations;

namespace HybridPlanner.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ServiceType { get; set; }

        public int? PartyId { get; set; }
        public Party? Party { get; set; }

        public int? LocationId { get; set; }
        public Location? Location { get; set; }
    }
}
