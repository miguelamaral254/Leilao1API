using Leilao1.Communication.Requests;
using Leilao1.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Leilao1.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : Leilao1Controller
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer([FromRoute] int itemId, [FromBody] RequestCreateOfferJson request)
    {
        return Created();
    }
}
