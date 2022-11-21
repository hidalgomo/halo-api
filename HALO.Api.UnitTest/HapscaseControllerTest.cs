using Moq;
using Xunit;
using HALO.Api.Interfaces;
using HALO.Api.Models.Case;
using HALO.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HALO.UnitTest;

public class HapsCaseControllerTest
{
    [Fact]
    public async void GetHapsCaseAsync_ReturnsHapscase()
    {
        string paNumber = "03306833716B";
        Mock<IHapsCaseService> mockedService = new Mock<IHapsCaseService>();
        mockedService.Setup(x => x.GetHapsCaseByPaNumberAsync(paNumber)).ReturnsAsync(new HapsCase());

        HapsCaseController controller = new HapsCaseController( mockedService.Object );

        ActionResult<HapsCase> response = await controller.GetHapsCaseAsync(paNumber);
        OkObjectResult okObject = Assert.IsType<OkObjectResult>(response.Result);

        Assert.IsType<HapsCase>(okObject.Value);
    }

    [Fact]
    public async void GetHapsCaseAsync_ReturnsNull()
    {
        string paNumber = "00006833716B";
        Mock<IHapsCaseService> mockedService = new Mock<IHapsCaseService>();
        mockedService.Setup(x => x.GetHapsCaseByPaNumberAsync(paNumber)).ReturnsAsync((HapsCase) null);

        HapsCaseController controller = new HapsCaseController( mockedService.Object );

        ActionResult<HapsCase> response = await controller.GetHapsCaseAsync(paNumber);
        OkObjectResult okObject = Assert.IsType<OkObjectResult>(response.Result);

        Assert.Null(okObject.Value);
    }
}