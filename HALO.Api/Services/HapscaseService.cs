using HALO.Api.Models;
using HALO.Api.Contexts;
using HALO.Api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HALO.Api.Services;

public class HapscaseService : IHapscaseService
{
    private readonly HALOdB _database;

    public HapscaseService(HALOdB database)
    {
        this._database = database;
    }

    public async Task<Hapscase> GetHapscaseByPaNumberAsync(string PaNumber)
    {
        return await this._database.Hapscases
            .Where(x => x.PaNumber == PaNumber)
            .OrderByDescending(x => x.ModDate)
            .Select(x => new Hapscase 
            {
                PaNumber = x.PaNumber
            })
            .SingleOrDefaultAsync();
    }
}