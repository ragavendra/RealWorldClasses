class Fridge
{
    private int _freezerSize;

    private int _coolerSize;

    private int _freezerTemp;
    private int _coolerTemp;

    public int FreezerTemp
    {
        get { return _freezerTemp; }
        set
        {
            if ((value < 0) && (value > -40))
                _freezerTemp = value;
        }
    }

    public int CoolerTemp
    {
        get { return _coolerTemp; }
        set
        {
            if ((value > 0) && (value < 20))
                _coolerTemp = value;
        }
    }
}
