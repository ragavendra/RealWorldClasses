using Xunit;
using RealWorldClasses.Electronics;
using Moq;
using RealWorldClasses.Electronics.Switches;

namespace RealWorldClassesTests.Tests.Electronics;

public class OrTests
{
    [Theory]
    [InlineData(true, true)]
    [InlineData(true, false)]
    [InlineData(false, true)]
    public void Or(bool a, bool b)
    {
        // Forgive the var names
        // Arrange
        var inpnMock = new Mock<Or>();
        var linkA = new Link() { };
        inpnMock.Setup(x => x.A).Returns(a);
        inpnMock.Setup(x => x.B).Returns(b);

        // Act
        var singlePoleSingelThrow = inpnMock.Object;

        // Assert
        Assert.True(singlePoleSingelThrow.Result());
    }

    [InlineData(false, false)]
    public void Orf(bool a, bool b)
    {
        // Forgive the var names
        // Arrange
        var inpnMock = new Mock<Or>();
        var linkA = new Link() { };
        inpnMock.Setup(x => x.A).Returns(a);
        inpnMock.Setup(x => x.B).Returns(b);

        // Act
        var singlePoleSingelThrow = inpnMock.Object;

        // Assert
        Assert.True(singlePoleSingelThrow.Result());
    }
}