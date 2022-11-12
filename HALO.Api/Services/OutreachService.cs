using HALO.Api.Models;
using HALO.Api.Contexts;
using HALO.Api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HALO.Api.Services;

public class OutreachService : IOutreachService
{
    private readonly HALOdB _database;

    public OutreachService(HALOdB database)
    {
        this._database = database;
    }

    public async Task<IList<Outreach>> GetOutreachesAsync()
    {
        return await this._database.Outreaches
            .Select(x => new Outreach
            {
                OutreachId = x.OutreachId
            })
            .ToListAsync();
    }

    public async Task<Outreach> GetOutreachByOutreachIdAsync(int OutreachId)
    {
        return await this._database.Outreaches
            .Where(x => x.OutreachId == OutreachId)
            .Select(x => new Outreach
            {
                OutreachId = x.OutreachId
            })
            .SingleOrDefaultAsync();
    }

    public async Task<Outreach> AddOutreachAsync(Outreach Outreach)
    {
        OutreachEntity outreachEntity = new OutreachEntity();
        await this._database.AddAsync(outreachEntity);
        await this._database.SaveChangesAsync();
        Outreach.OutreachId = outreachEntity.OutreachId;
        return Outreach;
    }
}