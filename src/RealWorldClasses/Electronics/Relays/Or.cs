
namespace RealWorldClasses.Electronics.Switches
{
    // three pin, second one for small power source to activate switch
    public class Or 
    {
        #region Switch specific

        private bool _a;

        private bool _b;

        #endregion

        public virtual bool A { get => _a; set => _a = value; }

        public virtual bool B { get => _b; set => _b = value; }

        /// <summary>
        /// Evaluates the result of the Or operation.
        /// </summary>
        /// <returns>True value base on A and B</returns>
        public bool Result()
        {
            switch (A)
            {
                case true when B is true:
                    return true;

                case false when B is true:
                    return true;

                case true when B is false:
                    return true;
                
                case false when B is false:
                    return false;
            }

            return default;
        }
    }
}