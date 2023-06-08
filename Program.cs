using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealWorldClasses;

//turn on and listen to radio with 25 volume and fm 101.5
Radio radio = new Radio() { AmFm = amFm.AM};

// set to AM
// radio.AmFm = amFm.AM;

radio.IncreaseVolume = 1;

radio.Volume = 25;
radio.Station = 101.5;
radio.Station = 25;  //should not set
radio.Display();