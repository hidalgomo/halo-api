using Moq;
using Xunit;
using HALO.Api.Models;
using HALO.Api.Interfaces;
using HALO.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HALO.UnitTest;

public class CarescasesControllerTest
{
    [Fact]
    public async void GetCarescasesAsync_ReturnsNonEmptyCol()
    {
        int CAREiD = 10147852;
        Mock<ICarescaseService> mockedService = new Mock<ICarescaseService>();
        mockedService.Setup(x => x.GetCarescasesByCaresIdAsync(CAREiD)).ReturnsAsync(new Carescase[] { new Carescase() });
        CarescasesController controller = new CarescasesController(mockedService.Object);
        
        ActionResult<Collection<Carescase>> response = await controller.GetCarescasesAsync(CAREiD);
        OkObjectResult okObject = Assert.IsType<OkObjectResult>(response.Result);
        Collection<Carescase> collection = (Collection<Carescase>) okObject.Value;

        Assert.NotEmpty(collection.Data);
    }
}