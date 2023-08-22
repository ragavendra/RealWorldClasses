
namespace RealWorldClasses.Electronics
{
    public class Battery : Electronics
    {
        #region Battery specific

        private readonly TimeSpan _shelfLife;

        private readonly TimeSpan _inUseLife;

        #endregion

        // Can be set once only
        public TimeSpan ShelfLife { get => _shelfLife; }

        // Can be set once only
        public TimeSpan InUseLife { get => _inUseLife; }

        public Battery(float amperage, float voltage) : base(amperage, voltage)
        {
            // _voltage = voltage;
            // _amperage = amperage;
        }

        public Battery(float amperage, float voltage, TimeSpan shelfLife, TimeSpan inUseLife) : base(amperage, voltage)
        {
            // _voltage = voltage;
            // _amperage = amperage;
            _shelfLife = shelfLife;
            _inUseLife = inUseLife;
        }
    }
}