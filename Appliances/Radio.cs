using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace RealWorldClasses
{
    public enum amFm {
        AM = 0,
        FM = 1
    }

    class Radio {

        private int volume_;

        public int Volume {
            get {
                return volume_;
            }

            set {
                if (value <= 100)
                    volume_ = value;
            }
        }

        public void incrVol() {
            if (volume_ < 95)
                volume_ = volume_ + 5;
        }

        public void deccrVol() {
            if (volume_ > 5)
                volume_ = volume_ - 5;
        }

        private double frequency_;

        public double Station {
            get { return frequency_; }

            set
            {
                //for AM station
                if (amFm_ == amFm.AM)
                    if ((value < 600) && (value > 55))
                        frequency_ = value;
                    else { }
                //for FM station
                else
                    if ((value < 300) && (value > 35))
                    frequency_ = value;
            }
        }

        public bool onOff = false;

        //set default to FM
        public amFm amFm_ = amFm.FM;

        public void Display() {
            Console.WriteLine($"Station is: {amFm_}");
            Console.WriteLine($"Frequency is: {Station}");
            Console.WriteLine($"Volume is: {Volume}");
        }

        public Radio() {
        }

        ~Radio() { 
            amFm_ = amFm.FM;
            onOff = false;
        }

    }
}
