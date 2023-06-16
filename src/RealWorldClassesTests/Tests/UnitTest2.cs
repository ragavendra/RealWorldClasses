using Xunit;
using Moq;
using RealWorldClasses;
using RealWorldClasses.Birds;

namespace RealWorldClassesTests;

public class UnitTest2
{
    [Fact]
    public void Test6()
    {
        var stubAnimal = new Mock<IAnimal>();
        stubAnimal.Setup(stu => stu.EarsCount).Returns(6);

        Hummingbird hummingbird = new Hummingbird();
        Assert.True(hummingbird.Equals(stubAnimal));
    }
}