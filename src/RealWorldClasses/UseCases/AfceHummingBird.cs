using RealWorldClasses.Area;
using RealWorldClasses.Birds;

namespace RealWorldClasses.UseCases
{
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

    public class Listener : IArea
    {

        private readonly Coordinates _location;

        private readonly double _radius = 0.3;

        public double Radius
        {
            get => _radius;
        }

        public Listener(AfceHummingBird afceHummingBird, Coordinates location)
        {
            _location = location;

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
            Console.WriteLine($"{GetType().Name} heard - {message}");
        }
    }

    public class Listener2 : Listener
    {
        public Listener2(AfceHummingBird afceHummingBird, Coordinates location) : base(afceHummingBird, location)
        {
        }
    }


    public class Listener3 : Listener
    {
        public Listener3(AfceHummingBird afceHummingBird, Coordinates location) : base(afceHummingBird, location)
        {
        }
    }

}