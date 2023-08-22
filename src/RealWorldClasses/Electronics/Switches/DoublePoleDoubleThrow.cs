
namespace RealWorldClasses.Electronics.Switches
{
    // three pin, second one for small power source to activate switch
    public class DoublePoleDoubleThrow
    {
        #region Switch specific

        private Link _a;

        private Link _b;

        private Link _c;

        private Link _d;

        #endregion

        public virtual Link A { get => _a; set => _a = value; }

        public virtual Link B { get => _b; set => _b = value; }

        public virtual Link C { get => _c; set => _c = value; }

        public virtual Link D { get => _d; set => _d = value; }

        /// <summary>
        /// Checks if the switch is not connected From A to B
        /// </summary> /// <returns>True if not connected</returns>
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
 
        /// <summary>
        /// Checks if the switch is not connected From D to B
        /// </summary> /// <returns>True if not connected</returns>
        public bool DToB()
        {
            if(D.Equals(B))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if the switch is not connected From D to C
        /// </summary>
        /// <returns>True if not connected</returns>
        public bool DToC()
        {
            if(D.Equals(C))
            {
                return true;
            }

            return false;
        }
    }
}