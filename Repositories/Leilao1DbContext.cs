using Leilao1.Entities;
using Microsoft.EntityFrameworkCore;
namespace Leilao1.Repositories;

public class Leilao1DbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\MIGUEL\\Downloads\\leilaoDbNLW.db");
    }

}
