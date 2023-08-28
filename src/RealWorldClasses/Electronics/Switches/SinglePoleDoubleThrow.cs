
namespace RealWorldClasses.Electronics.Switches
{
    // three pin, second one for small power source to activate switch
    public class SinglePoleDoubleThrow : Switch
    {
        #region Switch specific

        private Link _a;

        private Link _b;

        private Link _c;

        #endregion

        public virtual Link A { get => _a; set => _a = value; }

        public virtual Link B { get => _b; set => _b = value; }

        public virtual Link C { get => _c; set => _c = value; }

        /// <summary>
        /// Single Pole Double Throw switch. Connects either A to B or A to C
        /// </summary>
        public SinglePoleDoubleThrow(Link a, Link b, Link c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        /// <summary>
        /// Checks if the switch is not connected From A to B
        /// </summary>
        /// <returns>True if not connected</returns>
        public bool AToB()
        {
            if(A.Equals(B))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if the switch is not connected From A to C
        /// </summary>
        /// <returns>True if not connected</returns>
        public bool AToC()
        {
            if(A.Equals(C))
            {
                return true;
            }

            return false;
        }
    }
}