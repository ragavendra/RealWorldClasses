using Xunit;
using RealWorldClasses.Electronics;
using Moq;
using RealWorldClasses.Electronics.Switches;

namespace RealWorldClassesTests.Tests.Electronics;

public class SinglePoleSingelThrowTests
{
    [Fact]
    public void IsConnected()
    {
        // Arrange
        var inpnMock = new Mock<SinglePoleSingleThrow>();
        var linkA = new Link() { };
        inpnMock.Setup(x => x.A).Returns(linkA);

        // Act
        var singlePoleSingelThrow = inpnMock.Object;

        // Assert
        Assert.True(singlePoleSingelThrow.IsOpen());
    }

    [Fact]
    public void Close()
    {
        // Arrange
        var inpnMock = new Mock<SinglePoleSingleThrow>();
        var linkA = new Link() { };
        inpnMock.Setup(x => x.A).Returns(linkA);
        inpnMock.Setup(x => x.B).Returns(linkA);

        // Act
        var singlePoleSingelThrow = inpnMock.Object;

        // Assert
        Assert.False(singlePoleSingelThrow.IsOpen());
    }
}