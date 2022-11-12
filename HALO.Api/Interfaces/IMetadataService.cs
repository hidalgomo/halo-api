namespace HALO.Api.Interfaces;

public interface IMetadataService
{
    Task<IList<T1>> GetMetadataAsync<T1>() where T1 : class;
}