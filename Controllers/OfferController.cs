using Leilao1.Communication.Requests;
using Leilao1.Filters;
using Leilao1.UseCases.Auctions.Offers;
using Microsoft.AspNetCore.Mvc;

namespace Leilao1.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : Leilao1Controller
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer(
        [FromRoute] int itemId,
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemId, request);
        return Created(string.Empty, id);

    }
}
