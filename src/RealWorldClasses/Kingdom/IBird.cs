
public interface IBird : IAnimal
{
    public bool Fly { get; set;}

    public bool Flying { get; set;}

#region Bird speicifics
    public int BeakLength { get; set;}
#endregion

    // in km / hour
    public int MovingSpeed { get; set;}
}