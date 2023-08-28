
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

        public virtual bool A { get => _a; set => _a = value; }

        public virtual bool B { get => _b; set => _b = value; }

        public virtual bool C { get => _c; set => _c = value; }

        public virtual bool Result()
        {
            throw new NotImplementedException();
        }
    }
}