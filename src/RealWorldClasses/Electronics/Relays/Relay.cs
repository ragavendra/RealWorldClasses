
namespace RealWorldClasses.Electronics.Relays
{
    // C is the output pin
    public class Relay : IRelay
    {
        #region Relay specific

        private bool _a;

        private bool _b;

        private bool _c;

        #endregion

        public bool A { get => _a; set => _a = value; }

        public bool B { get => _b; set => _b = value; }

        public bool C { get => _c; set => _c = value; }

        public bool Result()
        {
            throw new NotImplementedException();
        }
    }
}