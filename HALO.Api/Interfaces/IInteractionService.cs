namespace HALO.Api.Interfaces;

public interface IInteractionService
{
    Task<IList<object[]>> GetInteractionsAsync();
}