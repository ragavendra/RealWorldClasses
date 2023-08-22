
namespace RealWorldClasses.Electronics
{
    public class Resistor : Electronics
    {
        #region Resistor specific

        private readonly float _resistance;

        #endregion

        // Can be set once only
        public float Resistance { get => _resistance; }

        public Resistor(float resistance)
        {
            _resistance = resistance;
        }
    }
}