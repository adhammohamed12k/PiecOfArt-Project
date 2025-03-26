using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace PiecOfArt_Project.Models
{
    public class ArtPiece
    {
        [Key]
        public int ArtPieceId { get; set; }
        [Required]
        public string? ArtPieceTitle { get; set; }
        [Required]
        public string? ArtPieceDescription { get; set; }
        
        public decimal Price { get; set; }  

        public Category? Category { get; set; }

        public Customer? Customer{ get; set; }
    }
}
