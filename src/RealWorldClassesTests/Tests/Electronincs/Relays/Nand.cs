using Xunit;
using Moq;
using RealWorldClasses.Electronics.Relays;

namespace RealWorldClassesTests.Tests.Electronics;

public class NandTests
{
    [Theory]
    [InlineData(true, false)]
    [InlineData(false, true)]
    [InlineData(false, false)]
    public void Nand(bool a, bool b)
    {
        // Forgive the var names
        // Arrange
        var or = new Nand(){ A = a, B = b };

        // Act

        // Assert
        Assert.True(or.Result());
    }

    [Theory]
    [InlineData(true, true)]
    public void Nandf(bool a, bool b)
    {
        // Forgive the var names
        // Arrange
        var or = new Nand(){ A = a, B = b };

        // Act

        // Assert
        Assert.False(or.Result());
    }
}