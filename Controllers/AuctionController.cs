using Leilao1.Entities;
using Leilao1.UseCases.Auctions.GetCurrent;
using Microsoft.AspNetCore.Mvc;

namespace Leilao1.Controllers;

public class AuctionController : Leilao1Controller
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuction()
    {
        GetCurrentAuctionUseCaseClass useCase = new GetCurrentAuctionUseCaseClass();
        var result = useCase.Execute();
        if (result == null)
        {
            return NoContent();
        }
        return Ok(result);
    }

}

