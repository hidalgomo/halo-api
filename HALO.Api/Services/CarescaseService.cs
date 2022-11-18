
using HALO.Api.Contexts;
using HALO.Api.Interfaces;
using HALO.Api.Models.Case;
using Microsoft.EntityFrameworkCore;

namespace HALO.Api.Services;

public class CaresCaseService : ICaresCaseService
{
    private readonly HALOdB _database;

    public CaresCaseService(HALOdB database)
    {
        this._database = database;
    }

    public async Task<IList<CaresCase>> GetCaresCasesByCaresIdAsync(int CaresId)
    {
        return await this._database.CaresCases.Where(x => x.CaseId == CaresId && x.HocCaresId == CaresId)
            .OrderByDescending(x => x.CheckOutDate)
            .Select(x => new CaresCase
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