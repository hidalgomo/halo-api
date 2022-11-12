using HALO.Api.Models;

namespace HALO.Api.Interfaces;

public interface IHapscaseService
{
    Task<Hapscase> GetHapscaseByPaNumberAsync(string PaNumber);
}