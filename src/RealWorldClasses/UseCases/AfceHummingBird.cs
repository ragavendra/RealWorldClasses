using RealWorldClasses.Birds;

namespace RealWorldClasses.UseCases
{
    public sealed class AfceHummingBird : Hummingbird
    {
        public delegate void EventHandler(string message);

        public event EventHandler Message;
        // { get; set; }

        public void TweetMessage(string tweet)
        {
            Message?.Invoke(tweet + " tweet!");
        }

        public void GroakMessage(string groak)
        {
            Message?.Invoke(groak + " groak!");
        }
    }

    public class Listener
    {
        public Listener(AfceHummingBird afceHummingBird)
        {
            afceHummingBird.Message += PrintMessage;
        }

        void PrintMessage(string message)
        {
            Console.WriteLine($"{GetType().Name} heard - {message}");
        }
    }

    public class Listener2
    {
        public Listener2(AfceHummingBird afceHummingBird)
        {
            afceHummingBird.Message += PrintMessage;
        }

        void PrintMessage(string message)
        {
            Console.WriteLine($"{GetType().Name} heard - {message}");
        }
    }

    public class Listener3
    {
        public Listener3(AfceHummingBird afceHummingBird)
        {
            afceHummingBird.Message += PrintMessage;
        }

        void PrintMessage(string message)
        {
            Console.WriteLine($"{GetType().Name} heard - {message}");
        }

        protected string SomeStr { get; set; }
    }

}