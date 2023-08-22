
namespace RealWorldClasses.Electronics.Switches
{
    // three pin, second one for small power source to activate switch
    public class SinglePoleSingleThrow
    {
        #region Switch specific

        private Link _a;

        private Link _b;

        #endregion

        public virtual Link A { get => _a; set => _a = value; }

        public virtual Link B { get => _b; set => _b = value; }

        public SinglePoleSingleThrow()
        {
            // _amperage = amperage;
        }

        public bool Close()
        {
            B ??= A;
            A ??= B;

            return true;
        }

        /// <summary>
        /// Checks if the switch is not connected
        /// </summary>
        /// <returns>True if not connected</returns>
        public bool IsOpen()
        {
            if(A != B)
            {
                return true;
            }

            return false;
        }
    }
}