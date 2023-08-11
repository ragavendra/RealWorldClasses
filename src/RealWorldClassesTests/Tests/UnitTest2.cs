using Xunit;
using Moq;
using RealWorldClasses;
using RealWorldClasses.Birds;
using RealWorldClasses.Electronics;

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

    [Fact]
    public void ElectronicSchema()
    {
        float battVolts = 1.5f;
        float battAmps = 1;
        Battery battery = new Battery(battVolts, battAmps);

        float curr = 0.6f;
        float volts = 0.3f;
        LED led = new LED(curr, volts);

        // R = V/I == (1.5f - 0.3f)/ 0.6f
        float resistance = 2;
        Resistor resistor = new Resistor(resistance);

        // connect resistor
        // resistor.Anode = battery.Anode

        // connect battery
        battery.Anode = resistor.Anode = new Link();
        battery.Cathode = led.Cathode = new Link();

        resistor.Cathode = led.Anode = new Link();

        switch (resistance)
        {
            case 3 when resistance > 0:
                break;

            
        }





    }
}