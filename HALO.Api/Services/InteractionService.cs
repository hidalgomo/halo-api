using HALO.Api.Models;
using HALO.Api.Contexts;
using HALO.Api.Interfaces;

namespace HALO.Api.Services;

public class InteractionService : IInteractionService
{
    private readonly IMetadataService _metadataService;

    public InteractionService(IMetadataService metadataService)
    {
        this._metadataService = metadataService;
    }

    private object[] _Caster<TEntity>(IList<TEntity> List)
    {
        IList<object> result = new List<object>();

        foreach(TEntity item in List)
        {
            result.Add( (object)item );
        }
        return result.ToArray();
    }

    public async Task<IList<object[]>> GetInteractionsAsync()
    {
        var interactionTypes = await this._metadataService.GetMetadataAsync<InteractionTypeEntity>();
        var interactionReasons = await this._metadataService.GetMetadataAsync<InteractionReasonEntity>();
        var interactionOutcomes = await this._metadataService.GetMetadataAsync<InteractionOutcomeEntity>();

        List<object[]> result = new List<object[]>();

        result.Add( this._Caster<InteractionTypeEntity>( interactionTypes ) );
        result.Add( this._Caster<InteractionReasonEntity>( interactionReasons ) );
        result.Add( this._Caster<InteractionOutcomeEntity>( interactionOutcomes ) );
        result.Add( new String[] { "Types", "Reasons", "Outcomes" } );

        return result;
    }
}