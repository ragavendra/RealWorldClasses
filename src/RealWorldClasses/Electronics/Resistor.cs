
namespace RealWorldClasses.Electronics
{
    public class Resistor
    {
        #region Resistor specific

        private readonly float _resistance;

        private Link _anode;

        private Link _cathode;

        public Link Anode { get => _anode; set => _anode = value; }

        public Link Cathode { get => _cathode; set => _cathode = value; }

        #endregion

        // Can be set once only
        public float Resistance { get => _resistance; }

        public Resistor(float resistance)
        {
            _resistance = resistance;
        }
    }
}