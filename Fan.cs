namespace RealWorldClasses
{
    class Fan {

        public bool On { get; set; }

        public int speed {
            get { 
                return speed; 
            }
            set { 
                if(value < 100)
                    speed = value;
            }
        }
    }
}
