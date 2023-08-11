
namespace RealWorldClasses.Electronics
{
    public class Electronics
    {
        #region Resistor specific

        private readonly float _amperage;

        private readonly float _voltage;

        private float _inputAmperage;

        private float _inputVoltage;

        private bool _connected;

        private Link _anode;

        private Link _cathode;

        public Link Anode { get => _anode; set => _anode = value; }

        public Link Cathode { get => _cathode; set => _cathode = value; }

        #endregion

        // Can be set once only
        public float Amperage { get => _amperage; }

        // Can be set once only
        public float Voltage { get => _voltage; }

        // Can be set only
        public float InputAmperage { set => _inputAmperage = value; get => _inputAmperage;}

        // Can be set only
        public float InputVoltage { set => _inputVoltage = value; get => _inputVoltage; }

        public bool Connected
        {
            get => _connected;
            /*
            {
                if ((_anode != null) && (_cathode != null))
                {
                    _connected = true;
                    return _connected;
                }

                return false;
            };*/
        }

        // behaviour on connected to a battery source
        public bool Connect()
        {
            if ((_anode != null) && (_cathode != null))
            {
                _connected = true;
            }

            return false;
        }
    }
}