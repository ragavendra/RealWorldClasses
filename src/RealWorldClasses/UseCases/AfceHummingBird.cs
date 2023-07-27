using RealWorldClasses.Area;
using RealWorldClasses.Birds;

namespace RealWorldClasses.UseCases
{
    public class AfceBird
    {
        public static void Main()
        {

            // Create an humming bird named afceHummingBird in the respective location
            Coordinates coordinates = new Coordinates() { Latitude = 3.161, Longitude = 1.69 };
            AfceHummingBird afceHummingBird = new AfceHummingBird(coordinates);

            // Create listeners near various co - ords near the afceHummingBird
            Coordinates listenerCoordinates = new Coordinates() { Latitude = 3.161, Longitude = 1.69 };
            new Listener(afceHummingBird, listenerCoordinates, "One");

            try
            {
                // lets move this listener a bit further
                listenerCoordinates.Latitude = listenerCoordinates.Latitude + .31;
                new Listener(afceHummingBird, listenerCoordinates, "Two") { Radius = 6 };
            }
            catch (Exception ex)
            { }

            try
            {
                // lets move this listener a bit further
                listenerCoordinates.Latitude = listenerCoordinates.Longitude - .62;
                new Listener(afceHummingBird, listenerCoordinates, "Three") { Radius = 8 };
            }
            catch (Exception ex)
            { }

            afceHummingBird.GroakMessage("Hi");
            afceHummingBird.TweetMessage("Hello");
        }
    }

    public sealed class AfceHummingBird : Hummingbird, IArea
    {
        private readonly Coordinates _location;

        public Coordinates Location { get => _location; }

        public delegate void EventHandler(string message);

        public event EventHandler Message;
        // { get; set; }

        public AfceHummingBird(Coordinates location)
        {
            _location = location;
        }

        public void TweetMessage(string tweet)
        {
            Message?.Invoke(tweet + " tweet!");
        }

        public void GroakMessage(string groak)
        {
            Message?.Invoke(groak + " groak!");
        }
    }

    public class Listener : IArea, IDisposable
    {

        private readonly Coordinates _location;

        private bool _disposed;

        private string _name;

        // the radius around which this listener can listen
        private double _radius = 0.3;

        public double Radius
        {
            get => _radius;
            set => _radius = value;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if(disposing)
                {
                    // disp managed resources
                    // _radius = null;
                }
            }

            // disp un managed resources
            _disposed = true;
        }

        public Listener(AfceHummingBird afceHummingBird, Coordinates location, string name)
        {
            _location = location;
            _name = name;

            if(!NearMe(afceHummingBird.Location))
            {
                throw new ApplicationException($"{GetType()} is not near {typeof(AfceHummingBird)} .");
            }

            afceHummingBird.Message += PrintMessage;
        }

        // Check if the passed coords is near me
        public bool NearMe(Coordinates coordinates)
        {
            if(CheckCoords(_location.Latitude, coordinates.Latitude))
            {
                // Console.WriteLine("here ........");
                return CheckCoords(_location.Longitude, coordinates.Longitude);
            }

            return false;
        }

        private bool CheckCoords(double latLong, double unit)
        {
            if (latLong <= unit)
            {
                // Console.WriteLine("here unit ........");
                if((latLong + _radius) > unit)
                {
                    return true;
                }
            }
            else
            {
                if((latLong - _radius) <= unit)
                {
                    return true;
                }
            }

            return false;
        }

        public Coordinates Location { get => _location; }

        void PrintMessage(string message)
        {
            Console.WriteLine($"{GetType().Name} {_name} heard - {message}");
        }
    }
}