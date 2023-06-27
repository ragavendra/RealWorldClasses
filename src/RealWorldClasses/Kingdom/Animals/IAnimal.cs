
public interface IAnimal
{
    public int EyesCount { get; }

    public int EarsCount { get; }

    public int NoseCount { get; }

    public int MouthCount { get; }

    public int LegsCount { get; }

    // in inches
    public int LegsHeight { get; }

    // has tail?
    public bool Tail { get; }

    // in inches
    public int TailLength { get; }

    // can walk?
    public bool Walk { get; }

}