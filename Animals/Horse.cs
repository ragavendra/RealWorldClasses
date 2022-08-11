    class Horse {

        public int eyes = 2;
        public int ears = 2;
        public int legs = 4;
        public int tail = 1;

        public int runSpeed {//in km/h
            get { return runSpeed; }
            set { if (value < 300)
                    runSpeed = value;
            }
        }

        public bool Running() {
            if (runSpeed < 20)
                return false;
            return true;
        }

        public bool Walking() {
            if (runSpeed < 20)
                return true;
            return false;
        }
    
    }
