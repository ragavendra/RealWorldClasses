
namespace RealWorldClasses.Electronics
{
    public class Capacitor : Electronics
    {
        #region Capacitor specific

        private readonly float _capacitance;

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