using System.ComponentModel.DataAnnotations;

namespace HybridPlanner.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public int StreetNumber { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string PartyLocation { get; set; }
        [Required]
        public int GuestEstimate { get; set; }
        public List<Service>? services { get; set; }
        public List<User>? users { get; set; }


        public int PartyId { get; set; }
        public Party? Party { get; set; }
    }
}
