namespace RealWorldClasses
{
    class Fan {

        private int _speed;

        public bool On { get; set; }

        public int Speed {
            get { 
                return _speed; 
            }
            set { 
                if(value < 100)
                    _speed = value;
            }
        }
    }
}
