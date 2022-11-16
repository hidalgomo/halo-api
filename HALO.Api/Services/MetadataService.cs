using HALO.Api.Contexts;
using HALO.Api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HALO.Api.Services;

public class MetadataService : IMetadataService
{
    private readonly HALOdB _database;

    public MetadataService(HALOdB database)
    {
        this._database = database;
    }

    public async Task<IList<T1>> GetMetadataAsync<T1>() where T1 : class
    {
        return await this._database.Set<T1>().AsNoTracking().ToListAsync();
    }
}