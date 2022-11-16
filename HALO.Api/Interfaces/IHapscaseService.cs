using HALO.Api.Models;

namespace HALO.Api.Interfaces;

public interface IHapsCaseService
{
    Task<HapsCase> GetHapsCaseByPaNumberAsync(string PaNumber);
}