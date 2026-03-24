using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Auctions.Models;

public class Comment
{
    public int CommentId { get; set; }
    public string Content { get; set; }

    [Required]
    public string UserId { get; set; }
    public IdentityUser User { get; set; }

    public int ListingId { get; set; }
    public Listing Listing { get; set; }
}
