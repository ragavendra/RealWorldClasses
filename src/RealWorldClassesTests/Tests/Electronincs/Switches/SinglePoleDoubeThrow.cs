using Xunit;
using RealWorldClasses.Electronics;
using Moq;
using RealWorldClasses.Electronics.Switches;

namespace RealWorldClassesTests.Tests.Electronics;

public class SinglePoleDoubleThrowTests
{
    [Fact]
    public void AtoB()
    {
        // Arrange
        var inpnMock = new Mock<SinglePoleDoubleThrow>();
        var linkA = new Link() { };
        inpnMock.Setup(x => x.A).Returns(linkA);
        inpnMock.Setup(x => x.B).Returns(linkA);

        // Act
        var singlePoleSingelThrow = inpnMock.Object;

        // Assert
        Assert.True(singlePoleSingelThrow.AToB());
        Assert.False(singlePoleSingelThrow.AToC());
    }

    [Fact]
    public void AtoC()
    {
        // Arrange
        var inpnMock = new Mock<SinglePoleDoubleThrow>();
        var linkA = new Link() { };
        inpnMock.Setup(x => x.A).Returns(linkA);
        inpnMock.Setup(x => x.C).Returns(linkA);

        // Act
        var singlePoleSingelThrow = inpnMock.Object;

        // Assert
        Assert.True(singlePoleSingelThrow.AToC());
        Assert.False(singlePoleSingelThrow.AToB());
    }

    [Fact]
    public void AtoC_()
    {
        // Arrange
        var inpnMock = new Mock<SinglePoleDoubleThrow>();
        var linkA = new Link() { };
        inpnMock.Setup(x => x.A).Returns(linkA);
        inpnMock.Setup(x => x.C).Returns(linkA);
        inpnMock.Setup(x => x.B).Returns(linkA);

        // Act
        var singlePoleSingelThrow = inpnMock.Object;

        // Assert
        Assert.True(singlePoleSingelThrow.AToC());
        Assert.False(singlePoleSingelThrow.AToB());
    }
}