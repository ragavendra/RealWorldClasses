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

        private int _volume;

        private double _frequency;

        private bool _on;

        //set default to FM
        private amFm _amFm;

        public amFm AmFm
        {
            get { return _amFm; }

            set { _amFm = value; }
        }

        public int Volume {
            get {
                return _volume;
            }

            set {
                if (value <= 100)
                    _volume = value;
            }
        }

        public int IncreaseVolume
        {
            set
            {
                if (_volume < 95)
                {
                    _volume = _volume + 5;
                }
            }
            get { return _volume; }
        }

        public int DecreaseVolume
        {
            set
            {
                if (_volume > 5)
                {
                    _volume = _volume - 5;
                }
            }

            get{ return _volume; }
        }

        public double Station {
            get { return _frequency; }

            set
            {
                //for AM station
                if (_amFm == amFm.AM)
                    if ((value < 600) && (value > 55))
                        _frequency = value;
                    else { }
                //for FM station
                else
                    if ((value < 300) && (value > 35))
                    _frequency = value;
            }
        }

        public void Display() {
            Console.WriteLine($"Station is: {_amFm}");
            Console.WriteLine($"Frequency is: {Station}");
            Console.WriteLine($"Volume is: {Volume}");
        }

        public Radio()
        {
            _on = true;
            _amFm = amFm.FM;
        }

        ~Radio() { 
            _amFm = amFm.FM;
            _on = false;
        }

    }
}
