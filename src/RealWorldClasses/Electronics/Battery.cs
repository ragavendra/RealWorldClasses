
namespace RealWorldClasses.Electronics
{
    public class Battery
    {
        #region Resistor specific

        private readonly float _voltage;

        private readonly float _amperage;

        private readonly TimeSpan _shelfLife;

        private readonly TimeSpan _inUseLife;

        private Link _anode;

        private Link _cathode;

        #endregion

        // Can be set once only
        public float Voltage { get => _voltage; }

        // Can be set once only
        public float Amperage { get => _amperage; }

        // Can be set once only
        public TimeSpan ShelfLife { get => _shelfLife; }

        // Can be set once only
        public TimeSpan InUseLife { get => _inUseLife; }

        public Link Anode { get => _anode; set => _anode = value; }

        public Link Cathode { get => _cathode; set => _cathode = value; }

        public Battery(float voltage, float amperage)
        {
            _voltage = voltage;
            _amperage = amperage;
        }

        public Battery(float voltage, float amperage, TimeSpan shelfLife, TimeSpan inUseLife)
        {
            _voltage = voltage;
            _amperage = amperage;
            _shelfLife = shelfLife;
            _inUseLife = inUseLife;
        }
    }
}