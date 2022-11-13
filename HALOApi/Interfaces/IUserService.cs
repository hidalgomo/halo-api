using HALO.Api.Models;

namespace HALO.Api.Interfaces;

public interface IUserService
{
    Task<IList<User>> GetUsersAsync();
}
