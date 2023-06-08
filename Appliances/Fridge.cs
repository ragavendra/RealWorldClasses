class Fridge
{
    public int _freezerSize;

    public int _coolerSize;

    public int _freezerTemp;
    public int _coolerTemp;

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
