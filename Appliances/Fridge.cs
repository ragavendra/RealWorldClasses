class Fridge
{
    public int freezerSize;

    public int coolerSize;

    public int freezerTemp
    {
        get { return freezerTemp; }
        set
        {
            if ((value < 0) && (value > -40))
                freezerTemp = value;
        }
    }

    public int coolerTemp
    {
        get { return coolerTemp; }
        set
        {
            if ((value > 0) && (value < 20))
                coolerTemp = value;
        }
    }
}
