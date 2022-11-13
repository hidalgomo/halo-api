using HALO.Api.Models;
using HALO.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HALO.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OutreachesController : ControllerBase
{
    private readonly IOutreachService _outreachService;

    public OutreachesController(IOutreachService outreachService)
    {
        this._outreachService = outreachService;
    }

    [HttpGet(Name = nameof(GetOutreachesAsync))]
    public async Task<ActionResult<Collection<Outreach>>> GetOutreachesAsync()
    {
        IList<Outreach> outreaches = await this._outreachService.GetOutreachesAsync();
        Collection<Outreach> collection = new Collection<Outreach>();
        collection.Data = outreaches.ToArray();

        return Ok(collection);
    }

    [HttpGet("{OutreachId}", Name = nameof(GetOutreachAsync))]
    public async Task<ActionResult<Outreach>> GetOutreachAsync(int OutreachId)
    {
        Outreach outreach = await this._outreachService.GetOutreachByOutreachIdAsync(OutreachId);
        return Ok(outreach);
    }

    [HttpPost(Name = nameof(AddOutreachAsync))]
    public async Task<ActionResult<Outreach>> AddOutreachAsync([FromBody] Outreach Outreach)
    {
        await this._outreachService.AddOutreachAsync(Outreach);
        return Ok(Outreach);
    }
}
