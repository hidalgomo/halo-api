using HALO.Api.Models;
using HALO.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HALO.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InteractionsController : ControllerBase
{
    private readonly IInteractionService _interactionService;

    public InteractionsController(IInteractionService interactionService)
    {
        this._interactionService = interactionService;
    }

    [HttpGet(Name = nameof(GetInteractionsAsync))]
    [ResponseCache(VaryByHeader = "User-Agent", Duration = 604800)]
    public async Task<ActionResult<Collection<object[]>>> GetInteractionsAsync()
    {
        IList<object[]> interactions = await this._interactionService.GetInteractionsAsync();
        Collection<object[]> collection = new Collection<object[]>();
        collection.Data = interactions.ToArray();

        return Ok(collection);
    }
}