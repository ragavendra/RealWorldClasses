using Xunit;
using RealWorldClasses.Electronics;
using Moq;
using RealWorldClasses.Electronics.Switches;

namespace RealWorldClassesTests.Tests.Electronics;

public class SinglePoleSingleThrowTests
{
    [Fact]
    public void IsOpenMock()
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
    public void IsOpen()
    {
        // Arrange

        // Act
        var inpnMock = new SinglePoleSingleThrow();

        // Assert
        Assert.True(inpnMock.IsOpen());
    }

    [Fact]
    public void IsOpenNegative()
    {
        // Arrange
        var linkA = new Link() { };

        // Act
        var inpnMock = new SinglePoleSingleThrow(linkA);

        // Assert
        Assert.False(inpnMock.IsOpen());
    }

    [Fact]
    public void IsOpenNegativeMock()
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

    [Fact]
    public void Close()
    {
        // Arrange
        SinglePoleSingleThrow singlePoleSingleThrow = new SinglePoleSingleThrow(new Link());

        // Act
        singlePoleSingleThrow.Close();

        // Assert
        Assert.False(singlePoleSingleThrow.IsOpen());
        Assert.True(singlePoleSingleThrow.IsClosed());
    }

    [Fact]
    public void Open()
    {
        // Arrange
        SinglePoleSingleThrow singlePoleSingleThrow = new SinglePoleSingleThrow(new Link());

        // Act
        singlePoleSingleThrow.Open();

        // Assert
        Assert.False(singlePoleSingleThrow.IsClosed());
        Assert.True(singlePoleSingleThrow.IsOpen());
    }
}