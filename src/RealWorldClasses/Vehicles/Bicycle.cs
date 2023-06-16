
class Bicycle : IVehicle
{
    public int WheelsCount { get; set; } = 2;
    public int GearsCount { get; set; } = 3;
    public bool IsAutomatic { get; set; } = false;
    public Cadence cadence;
    public Gear gear;
}
