using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace PiecOfArt_Project.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(50)]
        public string? CustomerName { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public LoyaltyCard? LoyaltyCard { get; set; }
        public Collection<ArtPiece>? ArtPieces { get; set; }    
    }
}
