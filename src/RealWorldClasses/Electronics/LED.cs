
namespace RealWorldClasses.Electronics
{
    public class LED : Electronics, IDisposable
    {
        #region LED specific

        private bool _disposed;

        #endregion

        public LED(float amperage, float voltage)
        {
            _amperage = amperage;
            _voltage = voltage;
        }

        public bool Glowing()
        {
            if ((Anode != null) && (Cathode != null))
            {
                Connected = true;

                if ((InputVoltage == null) || (InputAmperage == null))
                {
                    Console.WriteLine("Please set input voltage or amperage");
                    return false;
                }

                // return true
                if ((_inputVoltage <= _voltage) && (_inputAmperage <= _amperage))
                {
                    return true;
                }
            }

            return false;
        }

        public void Dispose(bool dispose)
        {
            if(dispose)
            {
                // dispo un - mgd resources
                Dispose();
            }

            // dispo mgd resources
            GC.SuppressFinalize(this);

            _disposed = true;
            // throw new NotImplementedException();
        }

        public void Dispose()
        {
            if(!_disposed)
            {

            }
        }
    }
}