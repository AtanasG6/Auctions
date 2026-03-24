using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Auctions.ViewModels;

public class ListingVM
{
    public int ListingId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public IFormFile Image { get; set; }
    public bool IsSold { get; set; } = false;

    [Required]
    public string? UserId { get; set; }
    public IdentityUser? User { get; set; }
}
