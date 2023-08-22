using Xunit;
using RealWorldClasses.Electronics;

namespace RealWorldClassesTests.Tests;

public class Electronics
{
    [Fact]
    public void ElectronicSchema()
    {
        float battVolts = 1.5f;
        float battAmps = 1;
        Battery battery = new Battery(battAmps, battVolts);

        float curr = 0.6f;
        float volts = 0.3f;
        LED led = new LED(curr, volts);

        // R = V/I == (1.5f - 0.3f)/ 0.6f
        float resistance = 2;
        Resistor resistor = new Resistor(resistance);

        // connect resistor
        // resistor.Anode = battery.Anode

        // connect battery
        battery.Anode = resistor.Anode = new Link(battery.Amperage, battery.Voltage);
        battery.Cathode = led.Cathode = new Link(battery.Amperage, battery.Voltage);

        resistor.Cathode = led.Anode = new Link();

        switch (resistance)
        {
            case 3 when resistance > 0:
                break;

            
        }

    }
}