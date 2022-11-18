using Moq;
using Xunit;
using HALO.Api.Models;
using HALO.Api.Interfaces;
using HALO.Api.Controllers;
using HALO.Api.Models.Person;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HALO.UnitTest;

public class UsersControllerTest
{
    [Fact]
    public async void GetUsersAsync_ReturnsNonEmptyCol()
    {
        Mock<IUserService> userServiceMock = new Mock<IUserService>();
        userServiceMock.Setup(x => x.GetUsersAsync()).ReturnsAsync(new List<User>() { new User(), new User() });
        UsersController controller = new UsersController( userServiceMock.Object );

        ActionResult<Collection<User>> response = await controller.GetUsersAsync();
        OkObjectResult okObject = Assert.IsType<OkObjectResult>( response.Result );
        Collection<User> collection = (Collection<User>) okObject.Value;

        Assert.NotEmpty(collection.Data);
    }
}