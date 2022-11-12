using HALO.Api.Models;

namespace HALO.Api.Interfaces;

public interface IOutreachService
{
    Task<IList<Outreach>> GetOutreachesAsync();
    Task<Outreach> GetOutreachByOutreachIdAsync(int OutreachId);
    Task<Outreach> AddOutreachAsync(Outreach Outreach);
}