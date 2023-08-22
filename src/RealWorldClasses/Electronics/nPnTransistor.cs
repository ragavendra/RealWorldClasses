
namespace RealWorldClasses.Electronics
{
    // three pin, second one for small power source to activate switch
    public class nPnTranstistor : Electronics
    {
        #region Transistor specific

        private Link _power;

        #endregion

        public virtual Link Power { get => _power; set => _power = value; }


        public nPnTranstistor(float amperage) : base(amperage)
        {
            // _amperage = amperage;
        }

        public bool IsPowered()
        {
            if(Power.Amperage > 0)
            {
                Anode = Cathode;
                return true;
            }

            return false;
        }
    }
}