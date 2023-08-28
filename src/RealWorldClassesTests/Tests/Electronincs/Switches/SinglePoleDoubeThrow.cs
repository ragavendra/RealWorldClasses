using Xunit;
using RealWorldClasses.Electronics;
using Moq;
using RealWorldClasses.Electronics.Switches;

namespace RealWorldClassesTests.Tests.Electronics;

public class SinglePoleDoubleThrowTests
{
    [Fact]
    public void AtoBMock()
    {
        // Arrange
        var inpnMock = new Mock<SinglePoleDoubleThrow>();
        var linkA = new Link() { };
        inpnMock.Setup(x => x.A).Returns(linkA);
        inpnMock.Setup(x => x.B).Returns(linkA);

        // Act
        var singlePoleSingelThrow = inpnMock.Object;

        // Assert
        Assert.True(singlePoleSingelThrow.IsAToB());
        Assert.False(singlePoleSingelThrow.IsAToC());
    }

    [Fact]
    public void AtoCMock()
    {
        // Arrange
        var inpnMock = new Mock<SinglePoleDoubleThrow>();
        var linkA = new Link() { };
        inpnMock.Setup(x => x.A).Returns(linkA);
        inpnMock.Setup(x => x.C).Returns(linkA);

        // Act
        var singlePoleSingelThrow = inpnMock.Object;

        // Assert
        Assert.True(singlePoleSingelThrow.IsAToC());
        Assert.False(singlePoleSingelThrow.IsAToB());
    }

    [Fact]
    public void AtoC_Mock()
    {
        // Arrange
        var inpnMock = new Mock<SinglePoleDoubleThrow>();
        var linkA = new Link() { };
        inpnMock.Setup(x => x.A).Returns(linkA);
        inpnMock.Setup(x => x.C).Returns(linkA);
        inpnMock.Setup(x => x.B).Returns(linkA);

        // Act
        var singlePoleSingelThrow = inpnMock.Object;
        singlePoleSingelThrow.CloseAtoC(linkA);

        // Assert
        Assert.True(singlePoleSingelThrow.IsAToC());
        Assert.False(singlePoleSingelThrow.IsAToB());
    }

    [Fact]
    public void AtoB()
    {
        // Arrange
        var linkA = new Link() { };
        var inpnMock = new SinglePoleDoubleThrow(linkA);

        // Act

        // Assert
        Assert.True(inpnMock.IsAToB());
        Assert.False(inpnMock.IsAToC());
    }

    [Fact]
    public void AtoC()
    {
        // Arrange
        var linkA = new Link() { };
        var inpnMock = new SinglePoleDoubleThrow(linkA, linkA);

        // Act
        inpnMock.CloseAtoC(linkA);

        // Assert
        Assert.True(inpnMock.IsAToC());
        Assert.False(inpnMock.IsAToB());
    }
}