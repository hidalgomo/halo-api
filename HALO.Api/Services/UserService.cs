using HALO.Api.Models;
using HALO.Api.Contexts;
using HALO.Api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HALO.Api.Services;

public class UserService : IUserService
{
    private readonly HALOdB _database;

    public UserService(HALOdB database)
    {
        this._database = database;
    }

    public async Task<IList<User>> GetUsersAsync()
    {
        return await this._database.Users
            .Where(x => x.IsActive)
            .Select(x => new User
            {
                UserId = x.UserId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                IsActive = x.IsActive,
                UserName = x.UserName
            })
            .ToListAsync();
    }
}
