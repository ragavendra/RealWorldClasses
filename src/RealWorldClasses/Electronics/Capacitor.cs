
namespace RealWorldClasses.Electronics
{
    public class Capacitor
    {
        #region Capacitor specific

        private readonly float _capacitance;

        private Link _anode;

        private Link _cathode;

        public Link Anode { get => _anode; set => _anode = value; }

        public Link Cathode { get => _cathode; set => _cathode = value; }

        #endregion

        // Can be set once only
        public float Capacitance { get => _capacitance; }

        public Capacitor(float capacitance)
        {
            _capacitance = capacitance;
        }

        // time left after charge with a certain resistance
        public TimeSpan TimeLeft(float resistance) => TimeSpan.FromSeconds(resistance * _capacitance); 


    }
}