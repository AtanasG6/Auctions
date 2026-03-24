using Auctions.Models;

namespace Auctions.Services;

public interface IListingsService
{
    IQueryable<Listing> GetAll(); //With IQueryable instead of List<Listing>, big performance boost, because we can use it with LINQ and it will be executed on the database side, not in memory 
    Task Add(Listing listing);
    Task<Listing> GetById(int? id);
    Task SaveChanges();
}
