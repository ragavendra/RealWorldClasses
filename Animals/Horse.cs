public class Horse : Animal, IVertebrates
{
    private int _eyesCount = 2;
    private int _earsCount = 2;
    private int _legsCount = 4;
    private bool _tail = true;
    private bool _backbone = true;
    public bool Backbone{ get { return _backbone; } set { _backbone = value; } }

    public Horse()
    {
        EyesCount = _eyesCount;
        LegsCount = _legsCount;
        EarsCount = _earsCount;
        HasTail = _tail;
        Backbone = _backbone;
    }

    public int RunSpeed
    {//in km/h
        get { return RunSpeed; }
        set
        {
            if (value < 300)
                RunSpeed = value;
        }
    }

    public bool Running
    {
        get
        {
            if (RunSpeed < 20)
            {
                return false;
            }
            return true;
        }
    }

    public bool Walking
    {
        get
        {
            if (RunSpeed < 20)
            {
                return true;
            }
            return false;
        }
    }

    // bool IVertebrates.Backbone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
