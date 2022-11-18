using HALO.Api.Models;
using HALO.Api.Interfaces;
using HALO.Api.Models.Person;
using Microsoft.AspNetCore.Mvc;

namespace HALO.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        this._userService = userService;
    }

    [HttpGet(Name = nameof(GetUsersAsync))]
    [ResponseCache(VaryByHeader = "User-Agent", Duration = 86400)]
    public async Task<ActionResult<Collection<User>>> GetUsersAsync()
    {
        IList<User> users = await this._userService.GetUsersAsync();
        Collection<User> collection = new Collection<User>();
        collection.Data = users.ToArray();
        
        return Ok(collection);
    }
}
