using HALO.Api.Models;
using HALO.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HALO.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarescasesController : ControllerBase
{
    private readonly ICarescaseService _carescaseService;

    public CarescasesController(ICarescaseService carescaseService)
    {
        this._carescaseService = carescaseService;
    }

    [HttpGet("{CareIds}", Name = nameof(GetCarescasesAsync))]
    public async Task<ActionResult<Collection<Carescase>>> GetCarescasesAsync(int CaresId)
    {
        IList<Carescase> carescases = await this._carescaseService.GetCarescasesByCaresIdAsync( CaresId);
        Collection<Carescase> collection = new Collection<Carescase>();
        collection.Data = carescases.ToArray();

        return Ok(collection);
    }
}