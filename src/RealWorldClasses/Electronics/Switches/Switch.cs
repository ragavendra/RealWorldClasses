
namespace RealWorldClasses.Electronics.Switches
{
    /// <summary>
    /// Switch is created, but not conntected.
    /// </summary>
    public class Switch
    {
        #region Switch specific

        private Link _a;

        private Link _b;

        #endregion

        public virtual Link A { get => _a; set => _a = value; }

        public virtual Link B { get => _b; set => _b = value; }

        /// <summary>
        /// Closes the switch between Links A and B.
        /// </summary>
        public virtual bool CloseAtoB()
        {
            B ??= A;
            A ??= B;

            if(A is null || B is null)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if the switch is not connected
        /// </summary>
        /// <returns>True if not connected</returns>
        public virtual bool IsOpen()
        {
            if(A is null || B is null)
            {
                return true;
            }

            if(A != B)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if the switch is closed. 
        /// </summary>
        /// <returns>True if connected</returns>
        public virtual bool IsClosed()
        {
            if(A is null || B is null)
            {
                return false;
            }

            if(A.Equals(B))
            {
                return true;
            }

            return  false;
        }

        /// <summary>
        /// Opens the switch.
        /// </summary>
        public virtual bool Open()
        {
            B = null; 
            A = null;

            return true;
        }
    }
}