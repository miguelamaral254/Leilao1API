using Leilao1.Entities;
using Leilao1.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Leilao1.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCaseClass
{   
    public Auction? Execute()
    {
        Leilao1DbContext repository = new Leilao1DbContext();
        DateTime today = new DateTime(2024,05,01) ;  

        return repository.
            Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends); //Function link
    }
}
