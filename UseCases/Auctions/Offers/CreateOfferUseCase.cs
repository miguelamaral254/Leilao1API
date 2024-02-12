﻿using Leilao1.Communication.Requests;
using Leilao1.Entities;
using Leilao1.Repositories;
using Leilao1.Services;
using Microsoft.EntityFrameworkCore;

namespace Leilao1.UseCases.Auctions.Offers;

public class CreateOfferUseCase
{
    private readonly LoggedUser _loggedUser;
    public CreateOfferUseCase(LoggedUser loggedUser) => _loggedUser = loggedUser;
    public int Execute(int itemId, RequestCreateOfferJson request)
    {
        var repository = new Leilao1DbContext();
        var user = _loggedUser.User();
        var offer = new Offer
        {
            CreatedOn = DateTime.Now,
            ItemId = itemId,
            Price = request.Price,
            UserId = user.Id,
        };
        repository.Offers.Add(offer);
        repository.SaveChanges();

        return offer.Id;






    }
}
