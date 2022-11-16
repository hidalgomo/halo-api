using HALO.Api.Models;
using HALO.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HALO.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HapsCaseController : ControllerBase
{
    private readonly IHapsCaseService _hapsCaseService;

    public HapsCaseController(IHapsCaseService hapsCaseService)
    {
        this._hapsCaseService = hapsCaseService;
    }

    [HttpGet("{PaNumber}", Name = nameof(GetHapsCaseAsync))]
    public async Task<ActionResult<HapsCase>> GetHapsCaseAsync(string PaNumber)
    {
        HapsCase hapsCase = await this._hapsCaseService.GetHapsCaseByPaNumberAsync(PaNumber);
        return Ok(hapsCase);
    }
}