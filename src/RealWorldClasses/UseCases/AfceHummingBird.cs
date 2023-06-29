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

        public event EventHandler Tweet;
        // { get; set; }

        public void TweetMessage(string tweet)
        {
            Tweet.Invoke(tweet);
        }
    }

    public class Listener
    {
        public Listener(AfceHummingBird afceHummingBird)
        {
            afceHummingBird.Tweet += PrintMessage;
        }

        void PrintMessage(string message)
        {
            Console.WriteLine($"{GetType().Name} heard - {message} !");
        }
    }

    public class Listener2
    {
        public Listener2(AfceHummingBird afceHummingBird)
        {
            afceHummingBird.Tweet += PrintMessage;
        }

        void PrintMessage(string message)
        {
            Console.WriteLine($"{GetType().Name} heard - {message} !");
        }
    }

    public class Listener3
    {
        public Listener3(AfceHummingBird afceHummingBird)
        {
            afceHummingBird.Tweet += PrintMessage;
        }

        void PrintMessage(string message)
        {
            Console.WriteLine($"{GetType().Name} heard - {message} !");
        }
    }
}