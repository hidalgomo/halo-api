
using HALO.Api.Models;
using HALO.Api.Contexts;
using HALO.Api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HALO.Api.Services;

public class CarescaseService : ICarescaseService
{
    private readonly HALOdB _database;

    public CarescaseService(HALOdB database)
    {
        this._database = database;
    }

    public async Task<IList<Carescase>> GetCarescasesByCaresIdAsync(int CaresId)
    {
        return await this._database.Carescases.Where(x => x.CaseId == CaresId && x.HocCaresId == CaresId)
            .OrderByDescending(x => x.CheckOutDate)
            .Select(x => new Carescase
            {
                CaseNumber = x.CaseNumber.ToString(),
                CaseType = x.CaseType,
                CheckInDate = x.CheckInDate,
                CheckOutDate = x.CheckOutDate,
                ExitDate = x.ExitDate,
                ExitReason = x.ExitReason,
                HocCaresId = x.HocCaresId,
            })
            .ToListAsync();
    }
} 