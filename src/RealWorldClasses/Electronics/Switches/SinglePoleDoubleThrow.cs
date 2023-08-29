
namespace RealWorldClasses.Electronics.Switches
{
    /// <inheritdoc />
    public class SinglePoleDoubleThrow : Switch
    {
        #region Switch specific

        private Link _c;

        #endregion

        public virtual Link C { get => _c; set => _c = value; }

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