
public interface IVehicle
{
    public int WheelsCount { get; set; }
    public int GearsCount { get; set; }
    public bool IsAutomatic { get; set; }
}

enum Gear
{
    first = 1,
    second = 2,
    third = 3,
    fourth = 4,
    fifth = 5,
    sixth = 6
}

enum Cadence
{
    first = 1,
    second = 2,
    third = 3
}
