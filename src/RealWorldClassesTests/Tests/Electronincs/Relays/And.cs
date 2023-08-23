using Xunit;
using Moq;
using RealWorldClasses.Electronics.Relays;

namespace RealWorldClassesTests.Tests.Electronics;

public class AndTests
{
    [Theory]
    [InlineData(true, false)]
    [InlineData(false, true)]
    [InlineData(false, false)]
    public void And(bool a, bool b)
    {
        // Forgive the var names
        // Arrange
        var or = new And(){ A = a, B = b };

        // Act

        // Assert
        Assert.False(or.Result());
    }

    [Theory]
    [InlineData(true, true)]
    public void Andf(bool a, bool b)
    {
        // Forgive the var names
        // Arrange
        var or = new And(){ A = a, B = b };

        // Act

        // Assert
        Assert.True(or.Result());
    }
}