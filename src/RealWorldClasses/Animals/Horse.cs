using RealWorldClasses.Kingdom.Animals;

public class Horse : Animal, IVertebrates
{
    private bool _backbone = true;

    #region Horse specific

    private int _legsHeight = 210;

    private int _tailLength = 170;

    #endregion

    public bool Backbone { get { return _backbone; } set { _backbone = value; } }

    //in inches
    public override int LegsHeight { get => _legsHeight; set => _legsHeight = value; }

    //in inches
    public override int TailLength { get => _tailLength; set => _tailLength = value; }
}