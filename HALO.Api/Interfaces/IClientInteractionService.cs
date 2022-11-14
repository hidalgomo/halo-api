using HALO.Api.Models;

namespace HALO.Api.Interfaces;

public interface IClientInteractionService {
    Task<IList<ClientInteraction>> GetClientInteractionsByClientIdAsync(int ClientId);
}