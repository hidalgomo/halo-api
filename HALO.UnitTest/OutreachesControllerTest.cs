using Moq;
using Xunit;
using HALO.Api.Models;
using HALO.Api.Interfaces;
using HALO.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HALO.UnitTest;

[ApiController]
[Route("api/[controller]")]
public class OutreachesControllerTest
{
    [Fact]
    public async void GetOutreachesAsync_ReturnsNonEmptyCol()
    {
        Mock<IOutreachService> mockedService = new Mock<IOutreachService>();
        mockedService.Setup(x => x.GetOutreachesAsync()).ReturnsAsync(new List<Outreach>() { new Outreach(), new Outreach() });
        OutreachesController controller = new OutreachesController(mockedService.Object); 

        ActionResult<Collection<Outreach>> response = await controller.GetOutreachesAsync();
        OkObjectResult okObject = Assert.IsType<OkObjectResult>(response.Result);
        Collection<Outreach> collection = (Collection<Outreach>) okObject.Value;

        Assert.NotEmpty(collection.Data);
    }

    [Fact]
    public async void GetOutreachAsync_ReturnsOutreach()
    {
        int outreachId = 7645;
        Mock<IOutreachService> mockedService = new Mock<IOutreachService>();
        mockedService.Setup(x => x.GetOutreachByOutreachIdAsync(outreachId)).ReturnsAsync(new Outreach());
        OutreachesController controller = new OutreachesController(mockedService.Object); 

        ActionResult<Outreach> response = await controller.GetOutreachAsync(outreachId);
        OkObjectResult okObject = Assert.IsType<OkObjectResult>(response.Result);
        Outreach outreach = (Outreach) okObject.Value;

        Assert.NotNull(outreach);
    }

    [Fact]
    public async void AddOutreachAsync_ReturnsOutreach()
    {
        Outreach outreach = new Outreach();
        Mock<IOutreachService> mockedService = new Mock<IOutreachService>();
        mockedService.Setup(x => x.AddOutreachAsync(outreach)).ReturnsAsync(outreach);
        OutreachesController controller = new OutreachesController(mockedService.Object); 

        ActionResult<Outreach> response = await controller.AddOutreachAsync(outreach);
        OkObjectResult okObject = Assert.IsType<OkObjectResult>(response.Result);

        Assert.NotNull(outreach.OutreachId);
    }
}