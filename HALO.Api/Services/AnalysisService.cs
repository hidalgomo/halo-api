using HALO.Api.Models;
using HALO.Api.Contexts;
using HALO.Api.Interfaces;

namespace HALO.Api.Services;

public class AnalysisService : IAnalysisService
{
    private readonly HALOdB _database;

    public AnalysisService(HALOdB database) 
    {
        this._database = database;
    }

    // NOT YET IMPLEMENETED
    public async Task<IList<Analysis>> GetAllAnalysisAsync()
    {
        await Task.Run(() => Thread.Sleep(100));
        return new List<Analysis>();
    }

    // NOT YET IMPLEMENETED
    public async Task<Analysis> GetAnalysisByAnalysisIdAsync(int AnalysisId)
    {
        await Task.Run(() => Thread.Sleep(100));
        return new Analysis();
    }
}