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

    public class Listener<T> where T : AfceHummingBird
    {
        public Listener(AfceHummingBird afceHummingBird)
        {
            afceHummingBird.Message += PrintMessage;
        }

        void PrintMessage(string message)
        {
            Console.WriteLine($"{GetType().Name} heard - {message}");
        }

        protected string SomeStr { get; set; }
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

    public class SomeType<T> : Listener<T> where T : AfceHummingBird
    {
        private int _someMesg;

        // public T type { get; set; }

        public SomeType(int someMesg) : base(new AfceHummingBird())
        {
            _someMesg = someMesg;
            // T someVar;
        }

        public string ToString(int num)
        {
            SomeStr = "xyz";
            return num.ToString();
        }

        public override string ToString()
        {
            // this.ToString();
            return _someMesg.ToString() + " plus.";
        }
    }
}