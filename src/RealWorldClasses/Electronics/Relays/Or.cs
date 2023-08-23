
namespace RealWorldClasses.Electronics.Relays
{
    // C is the output pin
    public class Or : Relay
    {
        /// <summary>
        /// Evaluates the result of the Or operation.
        /// </summary>
        /// <returns>True value base on A and B</returns>
        public bool Result()
        {
            switch (A)
            {
                case true when B is true:
                    C = true;
                    return C;

                case false when B is true:
                    C = true;
                    return C;

                case true when B is false:
                    C = true;
                    return C;
                
                case false when B is false:
                    C = false;
                    return C;
            }

            C = default;
            return C;
        }
    }
}