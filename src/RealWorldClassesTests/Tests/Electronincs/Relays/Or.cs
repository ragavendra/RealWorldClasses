using Xunit;
using Moq;
using RealWorldClasses.Electronics.Relays;

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
        var or = new Or(){ A = a, B = b };

        // Act

        // Assert
        Assert.True(or.Result());
    }

    [Theory]
    [InlineData(false, false)]
    public void Orf(bool a, bool b)
    {
        // Forgive the var names
        // Arrange
        var or = new Or(){ A = a, B = b };

        // Act

        // Assert
        Assert.False(or.Result());
    }

    [Theory]
    [InlineData(false, false)]
    public void Relay(bool a, bool b)
    {
        // Forgive the var names
        // Arrange
        var mock = new Mock<IRelay>();
        mock.Setup(r => r.Result()).Returns(false);

        // Act
        var or = mock.Object;

        // Assert
        Assert.False(or.Result());
    }
}