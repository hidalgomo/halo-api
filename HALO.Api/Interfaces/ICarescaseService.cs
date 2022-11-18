using HALO.Api.Models.Case;

namespace HALO.Api.Interfaces;

public interface ICaresCaseService
{
    Task<IList<CaresCase>> GetCaresCasesByCaresIdAsync(int CaresId);
}