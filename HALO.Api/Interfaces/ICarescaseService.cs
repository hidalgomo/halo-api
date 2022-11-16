using HALO.Api.Models;

namespace HALO.Api.Interfaces;

public interface ICaresCaseService
{
    Task<IList<CaresCase>> GetCaresCasesByCaresIdAsync(int CaresId);
}