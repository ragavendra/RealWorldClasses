
namespace RealWorldClasses.Electronics
{
    public class LED : IDisposable
    {
        #region Resistor specific

        private readonly float _amperage;

        private readonly float _voltage;

        private float _inputAmperage;

        private float _inputVoltage;

        private bool _connected;

        private bool _disposed;

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
        public float InputAmperage { set => _inputAmperage = value; }

        // Can be set only
        public float InputVoltage { set => _inputVoltage = value; }

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

        public LED(float amperage, float voltage)
        {
            _amperage = amperage;
            _voltage = voltage;
        }

        public bool Glowing()
        {
            if ((_anode != null) && (_cathode != null))
            {
                _connected = true;
                // return true
            }

            return false;
        }

        public bool Connect()
        {
            if ((_anode != null) && (_cathode != null))
            {
                _connected = true;
                // return true

                if ((_inputVoltage == _voltage) && (_inputAmperage == _amperage))
                {
                    return true;
                }
                else
                {
                    // burn the LED
                    Dispose();
                }
            }

            return false;
        }

        public void Dispose()
        {
            if(_disposed)
            {

            }

            GC.SuppressFinalize(this);
            _disposed = true;
            // throw new NotImplementedException();
        }
    }
}