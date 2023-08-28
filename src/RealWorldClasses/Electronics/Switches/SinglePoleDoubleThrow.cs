
namespace RealWorldClasses.Electronics.Switches
{
    // three pin, second one for small power source to activate switch
    public class SinglePoleDoubleThrow : Switch
    {
        #region Switch specific

        private Link _c;

        #endregion

        public virtual Link C { get => _c; set => _c = value; }

        /// <inheritdoc/>
        public SinglePoleDoubleThrow() : base()
        {
        }

        /// <inheritdoc/>
        public SinglePoleDoubleThrow(Link a) : base(a)
        {
        }

        /// <summary>
        /// Single Pole Double Throw switch. Connects A to B.
        /// For A to C connection use the <paramref name="a"/> <see cref="CloseAtoC"/>
        /// </summary>
        public SinglePoleDoubleThrow(Link a, Link c) : base(a)
        {
            _c = c;
        }

        public virtual bool CloseAtoC(Link link)
        {
            B = null;
            A = C = link;
            return true;
        }

        /// <summary>
        /// Checks if the switch is connected From A to B
        /// </summary>
        /// <returns>True if connected</returns>
        public bool IsAToB()
        {
            if(A is null || B is null)
            {
                return false;
            }

            if(A.Equals(B))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if the switch is connected From A to C
        /// </summary>
        /// <returns>True if connected</returns>
        public bool IsAToC()
        {
            if(A is null || C is null)
            {
                return false;
            }

            if(A.Equals(C))
            {
                return true;
            }

            return false;
        }
    }
}