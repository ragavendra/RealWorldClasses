
namespace RealWorldClasses.Electronics
{
    public interface IElectronics
    {
        #region Resistor specific

        public abstract Link Anode { get; set; }

        public abstract Link Cathode { get; set; }

        #endregion

        // Can be set once only
        public float Amperage { get; }

        // Can be set once only
        public float Voltage { get; }

        public bool Connected { get; set; }

        // behaviour on connected to a battery source
        public void Connect(Link anode, Link cathode);
    }
}