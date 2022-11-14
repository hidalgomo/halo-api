
using HALO.Api.Models;
using HALO.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HALO.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientInteractionController : ControllerBase
{
    private readonly IClientInteractionService _clientInteractionService;
    public ClientInteractionController(IClientInteractionService clientInteractionService)
    {
        this._clientInteractionService = clientInteractionService;
    }

    [HttpGet("{ ClientId }", Name = nameof(GetClientInteractions))]
    public async Task<ActionResult<Collection<ClientInteraction>>> GetClientInteractions(int ClientId)
    {
        IList<ClientInteraction> clientInteractions = await this._clientInteractionService.GetClientInteractionsByClientIdAsync(ClientId);
        Collection<ClientInteraction> collection = new Collection<ClientInteraction>();
        collection.Data = clientInteractions.ToArray();
        return Ok( collection );
    }
}