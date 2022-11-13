using Moq;
using Xunit;
using HALO.Api.Models;
using HALO.Api.Interfaces;
using HALO.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HALO.UnitTest;

public class InteractionsControllerTest
{
    [Fact]
    public async void GetInteractionsAsync_ReturnsNonEmptyCol()
    {
        Mock<IInteractionService> interactionServiceMock = new Mock<IInteractionService>();
        interactionServiceMock.Setup(x => x.GetInteractionsAsync()).ReturnsAsync( new List<object[]> { new object[]{}, new object[]{} } );
        InteractionsController controller = new InteractionsController( interactionServiceMock.Object );

        ActionResult<Collection<object[]>> response = await controller.GetInteractionsAsync();
        OkObjectResult okObject = Assert.IsType<OkObjectResult>( response.Result );
        Collection<object[]> collection = (Collection<object[]>) okObject.Value;

        Assert.NotEmpty(collection.Data);
    }
}