using HALO.Api.Models;
using HALO.Api.Contexts;
using HALO.Api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HALO.Api.Services;

public class ClientInteractionService : IClientInteractionService
{
    private readonly HALOdB _database;
    public ClientInteractionService(HALOdB database)
    {
        this._database = database;
    }
    public async Task<IList<ClientInteraction>> GetClientInteractionsByClientIdAsync(int ClientId)
    {
        return await this._database.ClientInteractions
            .Where(x => x.ClientId == ClientId)
            .Select(x => new ClientInteraction
            {
                ClientInteractionId = x.ClientInteractionId
            })
            .ToListAsync();
    }
}