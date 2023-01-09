using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace HybridPlanner.Models
{
    public class Party
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PartyName { get; set; }
        [Required]
        public string PartyDescription { get; set; }
        [Required]
        public DateTime PartyDate { get; set; }
        public List<Party>? Parties { get; set; }
        public List<Location>? Location { get; set; }
    }
}
