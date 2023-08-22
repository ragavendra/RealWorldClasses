using Xunit;
using RealWorldClasses.Electronics;
using Moq;

namespace RealWorldClassesTests.Tests.Electronics;

public class nPnTranstistorTests
{

    [Fact]
    public void IsConnected()
    {
        // Arrange
        var inpnMock = new Mock<nPnTranstistor>(It.IsAny<float>());
        var power = new Link() { Amperage = 1.6f };
        inpnMock.Setup(x => x.Power).Returns(power);

        // Act
        nPnTranstistor nPnTranstistor = inpnMock.Object;

        // Assert
        Assert.True(nPnTranstistor.IsPowered());
    }
}