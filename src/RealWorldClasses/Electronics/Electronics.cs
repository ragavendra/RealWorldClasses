
namespace RealWorldClasses.Electronics
{
    public class Electronics : IElectronics
    {
        #region Resistor specific

        private readonly float _amperage;

        private readonly float _voltage;

        private bool _connected;

        private Link _anode;

        private Link _cathode;

        public virtual Link Anode { get => _anode; set => _anode = value; }

        public virtual Link Cathode { get => _cathode; set => _cathode = value; }

        #endregion

        // Can be set once only
        public float Amperage { get => _amperage; }

        // Can be set once only
        public float Voltage { get => _voltage; }

        public Electronics()
        {}

        public Electronics(float amperage)
        {
            _amperage = amperage;
        }

        public Electronics(float amperage, float voltage)
        {
            _amperage = amperage;
            _voltage = voltage;
        }

        public bool Connected { get => _connected; set => _connected = value; }

        // behaviour on connected to a battery source
        public void Connect(Link anode, Link cathode)
        {
            _anode = anode;
            _cathode = cathode;
            _connected = true;
        }
    }
}