using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldClasses.Birds
{
    public class Hummingbird : IBird
    {
        private bool _fly = true;

        private int _eyesCount = 2;

        private int _earsCount = 2;

        private int _noseCount = 1;

        private int _mouthCount = 1;

        private int _legsCount = 2;

        private bool _flying = false;

        private int _flyingSpeed = 10;

        private bool _tail;

        public bool Fly { get { return _fly; } set { _fly = value; } }

        public int EyesCount { get { return _eyesCount; } set { _eyesCount = value; } }

        public int EarsCount { get { return _earsCount; } set { _earsCount = value; } }

        public int NoseCount { get { return _noseCount; } set { _noseCount = value; } }

        public int MouthCount { get { return _mouthCount; } set { _mouthCount = value; } }

        public int LegsCount { get { return _legsCount; } set { _legsCount = value; } }

        public bool Tail { get { return _tail; } set { _tail = value; } }

        public bool Flying
        {
            get { if (_flyingSpeed > 3) { _flying = true; return _flying; } else { return false; } }
            set { if (_flyingSpeed > 3) { _flying = true; } }
        }

        public int FlyingSpeed { get { return _flyingSpeed; } set { _flyingSpeed = value; } }
    }
}