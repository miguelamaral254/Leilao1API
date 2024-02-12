using Leilao1.Communication.Requests;
using Leilao1.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Leilao1.UseCases.Auctions.Offers;

public class CreateOfferUseCase
{
    public void Execute(int itemId, RequestCreateOfferJson request)
    {
        var repository = new Leilao1DbContext();

        var offer = new Offer
        {
            CreatedOn = DateTime.Now,
            ItemId = itemId,
            Price = request.Price,
            UserId = 
        }
        repository.Offers.Add()
        

            


    }
}
