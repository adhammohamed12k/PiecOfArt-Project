using Microsoft.EntityFrameworkCore;
using PiecOfArt_Project.Models;

namespace PiecOfArt_Project
{
    public class AppDbContextt : DbContext
    {
        public AppDbContextt(DbContextOptions options) : base(options)
        {
        }

        DbSet<LoyaltyCard> LoyaltyCards { get; set; }
        DbSet<ArtPiece> ArtPieces { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Customer> Customers { get; set; }

    }
}
