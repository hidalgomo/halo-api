using HALO.Api.Models;
using HALO.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HALO.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HapscaseController : ControllerBase
{
    private readonly IHapscaseService _hapscaseService;

    public HapscaseController(IHapscaseService hapscaseService)
    {
        this._hapscaseService = hapscaseService;
    }

    [HttpGet("{PaNumber}", Name = nameof(GetHapscaseAsync))]
    public async Task<ActionResult<Hapscase>> GetHapscaseAsync(string PaNumber)
    {
        Hapscase hapscase = await this._hapscaseService.GetHapscaseByPaNumberAsync(PaNumber);
        return Ok(hapscase);
    }
}