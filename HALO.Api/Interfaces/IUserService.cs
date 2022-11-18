using HALO.Api.Models.Person;

namespace HALO.Api.Interfaces;

public interface IUserService
{
    Task<IList<User>> GetUsersAsync();
}
