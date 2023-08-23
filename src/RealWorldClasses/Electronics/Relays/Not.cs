
namespace RealWorldClasses.Electronics.Relays
{
    // No B pin for me
    // C is the output pin
    public class Not : Relay
    {
        /// <summary>
        /// Evaluates the result of the Not operation.
        /// </summary>
        /// <returns>True value base on A and B</returns>
        public bool Result()
        {
            switch (A)
            {
                case true:
                    C = false;
                    return C;

                case false:
                    C = true;
                    return C;
            }
        }
    }
}