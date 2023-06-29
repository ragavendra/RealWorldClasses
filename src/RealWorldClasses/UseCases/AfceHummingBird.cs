using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealWorldClasses.Birds;

namespace RealWorldClasses.UseCases
{
    public class AfceHummingBird : Hummingbird
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
    }
}