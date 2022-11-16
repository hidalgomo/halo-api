using HALO.Api.Models;
using HALO.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HALO.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CaresCasesController : ControllerBase
{
    private readonly ICaresCaseService _caresCaseService;

    public CaresCasesController(ICaresCaseService caresCaseService)
    {
        this._caresCaseService = caresCaseService;
    }

    [HttpGet("{CareIds}", Name = nameof(GetCaresCasesAsync))]
    public async Task<ActionResult<Collection<CaresCase>>> GetCaresCasesAsync(int CaresId)
    {
        IList<CaresCase> caresCases = await this._caresCaseService.GetCaresCasesByCaresIdAsync( CaresId);
        Collection<CaresCase> collection = new Collection<CaresCase>();
        collection.Data = caresCases.ToArray();

        return Ok(collection);
    }
}