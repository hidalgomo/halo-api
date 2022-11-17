using HALO.Api.Models;

namespace HALO.Api.Interfaces;

public interface IAnalysisService
{
    Task<IList<Analysis>> GetAllAnalysisAsync();
    Task<Analysis> GetAnalysisByAnalysisIdAsync(int AnalysisId);
}