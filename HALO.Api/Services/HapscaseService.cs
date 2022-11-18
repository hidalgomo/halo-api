using HALO.Api.Contexts;
using HALO.Api.Interfaces;
using HALO.Api.Models.Case;
using Microsoft.EntityFrameworkCore;

namespace HALO.Api.Services;

public class HapsCaseService : IHapsCaseService
{
    private readonly HALOdB _database;

    public HapsCaseService(HALOdB database)
    {
        this._database = database;
    }

    public async Task<HapsCase> GetHapsCaseByPaNumberAsync(string PaNumber)
    {
        return await this._database.HapsCases
            .Where(x => x.PaNumber == PaNumber)
            .OrderByDescending(x => x.ModDate)
            .Select(x => new HapsCase 
            {
                PaNumber = x.PaNumber
            })
            .SingleOrDefaultAsync();
    }
}