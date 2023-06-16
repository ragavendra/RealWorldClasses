using Xunit;
using Moq;
using RealWorldClasses;
using RealWorldClasses.Birds;

namespace RealWorldClassesTests;

public class UnitTest2
{
    [Fact]
    public void HummingBirdFeatures()
    {
        var stubAnimal = new Mock<IAnimal>();
        stubAnimal.Setup(stu => stu.EarsCount).Returns(2);

        Hummingbird hummingbird = new Hummingbird();
        Assert.Equal(hummingbird.EarsCount, stubAnimal.Object.EarsCount);

        var stubBird = new Mock<IBird>();

        // stubBird.Setup(stu => stu.FlyingSpeed).Returns(6);
        Assert.False(stubBird.Object.Flying);

        // stubBird.Setup(stu => stu.FlyingSpeed).Returns(1);
        // Assert.True(stubBird.Object.Flying);

        Assert.Equal(hummingbird.Flying, !stubBird.Object.Flying);
    }
}