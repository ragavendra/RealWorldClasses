
namespace RealWorldClasses.Electronics
{
    public record Link
    {
        private float _amperage;

        private float _voltage;

        public Link A { get; set; }

        public Link B { get; set; }

        public float Amperage { get => _amperage ; set => _amperage = value; }

        public float Voltage { get => _voltage; set => _voltage = value; }

        public Link()
        {}

        public Link(float amperage, float voltage)
        {
            _amperage = amperage;
            _voltage = voltage;
        }

        public bool IsConnected()
        {
            if ((_amperage > 0) || (_voltage > 0))
            {
                return true;
            }

            return false;
        }
    }
}