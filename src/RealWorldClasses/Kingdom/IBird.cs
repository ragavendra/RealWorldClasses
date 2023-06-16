
public interface IBird : IAnimal
{
    public bool Fly { get; set;}

    public bool Flying { get; set;}

    // in km / hour
    public int FlyingSpeed { get; set;}
}