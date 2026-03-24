using Auctions.Data;
using Auctions.Models;
using Microsoft.EntityFrameworkCore;

namespace Auctions.Services;

public class ListingsService(ApplicationDbContext context) : IListingsService
{
    public IQueryable<Listing> GetAll() => context.Listings.Include(l => l.User).Where(l => l.IsSold == false);

    public async Task Add(Listing listing)
    {
        context.Listings.Add(listing);
        await this.SaveChanges();
    }

    public async Task<Listing> GetById(int? id)
    {
        throw new NotImplementedException();
    }

    public async Task SaveChanges()
    {
        await context.SaveChangesAsync();
    }
}
