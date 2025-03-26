using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace PiecOfArt_Project.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string? CategoryName { get; set; }

        public Collection<ArtPiece>? PieceOfArts { get; set; }

    }
}
