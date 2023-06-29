using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldClasses.Kingdom.Animals
{
    ///<summary>Base abstract class to hold the defaults for the bird.
    /// At this point assuming a bird has these deafult properties.</summary>
    public abstract class Bird : IBird
    {
        // can fly?
        private bool _fly = true;

        // can walk?
        private bool _walk = true;

        private int _eyesCount = 2;

        private int _earsCount = 2;

        private int _noseCount = 1;

        private int _mouthCount = 1;

        private int _legsCount = 2;

        private bool _walking;
        
        private bool _flying;

        private int _movingSpeed;

        private bool _tail = true;

        public bool Fly { get { return _fly; } set { _fly = value; } }

        public int EyesCount { get { return _eyesCount; } set { _eyesCount = value; } }

        public int EarsCount { get { return _earsCount; } set { _earsCount = value; } }

        public int NoseCount { get { return _noseCount; } set { _noseCount = value; } }

        public int MouthCount { get { return _mouthCount; } set { _mouthCount = value; } }

        public int LegsCount { get { return _legsCount; } set { _legsCount = value; } }

        #region  specific to a Bird

        public abstract int BeakLength { get; set; }

        public abstract int TailLength { get; set; }

        public abstract int LegsHeight { get; set; }

        #endregion

        public bool Tail { get { return _tail; } set { _tail = value; } }

        public bool Flying
        {
            get { return _flying; }
            set { if (_movingSpeed > 3) { _flying = true; } }
        }

        public bool Walking
        {
            get { return _walking; }
            set { if (_movingSpeed <= 3) { _walking = true; } }
        }

        public int MovingSpeed { get { return _movingSpeed; } set { _movingSpeed = value; } }

        public bool Walk { get { return _walk; }}
    }
}