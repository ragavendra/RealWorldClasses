
namespace RealWorldClasses.Electronics.Relays
{
    // C is the output pin
    public interface IRelay
    {
        public bool A { get; set; }

        public bool B { get; set; }

        public bool C { get; set; }

        public bool Result();
    }
}