using Moq;
using Xunit;
using HALO.Api.Models;
using HALO.Api.Interfaces;
using HALO.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HALO.UnitTest;

public class CaresCasesControllerTest
{
    [Fact]
    public async void GetCaresCasesAsync_ReturnsNonEmptyCol()
    {
        int CAREiD = 10147852;
        Mock<ICaresCaseService> mockedService = new Mock<ICaresCaseService>();
        mockedService.Setup(x => x.GetCaresCasesByCaresIdAsync(CAREiD)).ReturnsAsync(new CaresCase[] { new CaresCase() });
        CaresCasesController controller = new CaresCasesController(mockedService.Object);
        
        ActionResult<Collection<CaresCase>> response = await controller.GetCaresCasesAsync(CAREiD);
        OkObjectResult okObject = Assert.IsType<OkObjectResult>(response.Result);
        Collection<CaresCase> collection = (Collection<CaresCase>) okObject.Value;

        Assert.NotEmpty(collection.Data);
    }
}