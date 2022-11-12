using HALO.Api.Models;

namespace HALO.Api.Interfaces;

public interface ICarescaseService
{
    Task<IList<Carescase>> GetCarescasesByCaresIdAsync(int CaresId);
}