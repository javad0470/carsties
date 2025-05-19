using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;

// Migration Command in working Solution (here AuctionService)
// dotnet ef migrations add "Initial-Create" -o Data/Migrations

public class AuctionDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Auction> Auctions { get; set; }
}