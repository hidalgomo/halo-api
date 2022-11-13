using Moq;
using Xunit;
using HALO.Api.Models;
using HALO.Api.Interfaces;
using HALO.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HALO.UnitTest;

public class HapscaseControllerTest
{
    [Fact]
    public async void GetHapscaseAsync_ReturnsHapscase()
    {
        string paNumber = "00006833716B";
        Mock<IHapscaseService> mockedService = new Mock<IHapscaseService>();
        mockedService.Setup(x => x.GetHapscaseByPaNumberAsync(paNumber)).ReturnsAsync(new Hapscase());

        HapscaseController controller = new HapscaseController( mockedService.Object );

        ActionResult<Hapscase> response = await controller.GetHapscaseAsync(paNumber);
        OkObjectResult okObject = Assert.IsType<OkObjectResult>(response.Result);

        Assert.IsType<Hapscase>(okObject.Value);
    }

    [Fact]
    public async void GetHapscaseAsync_ReturnsNull()
    {
        string paNumber = "00006833716B";
        Mock<IHapscaseService> mockedService = new Mock<IHapscaseService>();
        mockedService.Setup(x => x.GetHapscaseByPaNumberAsync(paNumber)).ReturnsAsync((Hapscase) null);

        HapscaseController controller = new HapscaseController( mockedService.Object );

        ActionResult<Hapscase> response = await controller.GetHapscaseAsync(paNumber);
        OkObjectResult okObject = Assert.IsType<OkObjectResult>(response.Result);

        Assert.Null(okObject.Value);
    }
}