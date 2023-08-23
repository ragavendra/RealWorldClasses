using Xunit;
using Moq;
using RealWorldClasses.Electronics.Relays;

namespace RealWorldClassesTests.Tests.Electronics;

public class NorTests
{
    [Theory]
    [InlineData(true, true)]
    [InlineData(true, false)]
    [InlineData(false, true)]
    public void Nor(bool a, bool b)
    {
        // Forgive the var names
        // Arrange
        var or = new Nor(){ A = a, B = b };

        // Act

        // Assert
        Assert.False(or.Result());
    }

    [Theory]
    [InlineData(false, false)]
    public void Norf(bool a, bool b)
    {
        // Forgive the var names
        // Arrange
        var or = new Nor(){ A = a, B = b };

        // Act

        // Assert
        Assert.True(or.Result());
    }
}