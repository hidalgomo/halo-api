using Moq;
using Xunit;

namespace HALO.UnitTest;

public class ClientInteractionControllerTest
{
    [Fact]
    public async void GetClientInteractionsAsync_ReturnsBool()
    {
        Mock<IClientInteractionService> mockedService = new Mock<IClientInteractionService>();
    }
}