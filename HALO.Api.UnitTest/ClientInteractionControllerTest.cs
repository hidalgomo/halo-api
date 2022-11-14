using Moq;
using Xunit;
using HALO.Api.Models;
using HALO.Api.Interfaces;
using HALO.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HALO.UnitTest;

public class ClientInteractionControllerTest
{
    [Fact]
    public async void GetClientInteractionsAsync_ReturnsCollection()
    {
        int ClientId = 17877;

        Mock<IClientInteractionService> mockedService = new Mock<IClientInteractionService>();
        mockedService.Setup(x => x.GetClientInteractionsByClientIdAsync(ClientId)).ReturnsAsync( new ClientInteraction[] { new ClientInteraction() } );
        ClientInteractionController controller = new ClientInteractionController( mockedService.Object );

        ActionResult<Collection<ClientInteraction>> response = await controller.GetClientInteractions( ClientId );
        OkObjectResult okObject = Assert.IsType<OkObjectResult>(response.Result);
        Collection<ClientInteraction> collection = (Collection<ClientInteraction>) okObject.Value;

        Assert.NotEmpty(collection.Data);
    }
}