namespace RealWorldClasses.Kingdom.Animals
{
    public abstract class Animal : IAnimal
    {
        // can fly?
        private bool _fly = false;

        // can walk?
        private bool _walk = true;

        private int _eyesCount = 2;

        private int _earsCount = 2;

        private int _noseCount = 1;

        private int _mouthCount = 1;

        private int _legsCount = 2;

        private bool _walking;

        private int _movingSpeed;

        private bool _tail = true;

        public bool Fly { get { return _fly; } set { _fly = value; } }

        public int EyesCount { get { return _eyesCount; } set { _eyesCount = value; } }

        public int EarsCount { get { return _earsCount; } set { _earsCount = value; } }

        public int NoseCount { get { return _noseCount; } set { _noseCount = value; } }

        public int MouthCount { get { return _mouthCount; } set { _mouthCount = value; } }

        public int LegsCount { get { return _legsCount; } set { _legsCount = value; } }

        public bool Tail { get => _tail; set => _tail = value; }

        //in cms
        public abstract int LegsHeight { get; set; }

        //in cms
        public abstract int TailLength { get; set; }

        public bool Walking
        {
            get { return _walking; }
            set { if (_movingSpeed <= 3) { _walking = true; } }
        }

        public int MovingSpeed { get { return _movingSpeed; } set { _movingSpeed = value; } }

        public bool Walk { get { return true; } }

    }
}