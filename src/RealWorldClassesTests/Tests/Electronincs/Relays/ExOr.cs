using Xunit;
using Moq;
using RealWorldClasses.Electronics.Relays;

namespace RealWorldClassesTests.Tests.Electronics;

public class ExOrTests
{
    [Theory]
    [InlineData(true, false)]
    [InlineData(false, true)]
    public void ExOr(bool a, bool b)
    {
        // Forgive the var names
        // Arrange
        var or = new ExOr(){ A = a, B = b };

        // Act

        // Assert
        Assert.True(or.Result());
    }

    [Theory]
    [InlineData(true, true)]
    [InlineData(false, false)]
    public void ExOrF(bool a, bool b)
    {
        // Forgive the var names
        // Arrange
        var or = new ExOr(){ A = a, B = b };

        // Act

        // Assert
        Assert.False(or.Result());
    }
}