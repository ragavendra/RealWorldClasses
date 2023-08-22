using Xunit;
using Moq;
using RealWorldClasses;
using RealWorldClasses.Birds;
using RealWorldClasses.Electronics;

namespace RealWorldClassesTests.Tests;

public class Birds
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

    [Fact]
    public void HummingbirdEyesCount()
    {
        // Arrange
        var stubBird = new Mock<IBird>();
        stubBird.Setup(stu => stu.EyesCount).Returns(2);

        // Act
        Hummingbird hummingbird = new Hummingbird();

        // Assert
        Assert.Equal(stubBird.Object.EyesCount, hummingbird.EyesCount);
    }
}