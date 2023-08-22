
namespace RealWorldClasses.Electronics
{
    public class LED : Electronics, IDisposable
    {
        #region LED specific

        private bool _disposed;

        #endregion

        public LED(float amperage, float voltage) : base(amperage, voltage)
        {
            // _amperage = amperage;
            // _voltage = voltage;
        }

        public bool Glowing()
        {
            if (Connected)
            {
                // return true
                // if not burnt 
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