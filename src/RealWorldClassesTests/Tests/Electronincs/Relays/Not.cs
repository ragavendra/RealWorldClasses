using Xunit;
using RealWorldClasses.Electronics.Relays;

namespace RealWorldClassesTests.Tests.Electronics;

public class NotTests
{
    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void Not(bool a)
    {
        // Forgive the var names
        // Arrange
        var or = new Not(){ A = a };

        // Act

        // Assert
        if(a)
        {
            Assert.False(or.Result());
        }
        else
        {
            Assert.True(or.Result());
        }
    }
}