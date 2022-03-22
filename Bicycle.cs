
    enum Gear
    {
        first = 1,
        second = 2,
        third = 3,
        fourth = 4,
        fifth = 5,
        sixth = 6
    }

    enum Cadence { 
        first = 1,
        second = 2,
        third = 3
    }

    class Bicycle
    {
        public int wheels = 2;
        public int handle = 1;

        public Cadence cadence;
        public Gear gear;
    }
