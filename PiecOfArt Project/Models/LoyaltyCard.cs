using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace PiecOfArt_Project.Models
{
    public class LoyaltyCard
    {
        [Key]
        public int LoyaltyCardId { get; set; }
        [Required]
        public decimal Balance { get; set; }

        public Collection<ArtPiece>? ArtPieces { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
