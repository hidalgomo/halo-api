using HALO.Api.Models.Case;

namespace HALO.Api.Interfaces;

public interface IHapsCaseService
{
    Task<HapsCase> GetHapsCaseByPaNumberAsync(string PaNumber);
}