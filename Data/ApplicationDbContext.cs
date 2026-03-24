using Auctions.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Auctions.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext(options)
{
    public DbSet<Listing> Listings { get; set; }
    public DbSet<Bid> Bids { get; set; }
    public DbSet<Comment> Comments { get; set; }
}
