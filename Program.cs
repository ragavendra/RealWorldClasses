using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealWorldClasses;
using RealWorldClasses.Birds;

//turn on and listen to radio with 25 volume and fm 101.5
Radio radio = new Radio() { AmFm = amFm.AM};

// set to AM
// radio.AmFm = amFm.AM;

radio.IncreaseVolume = 1;

radio.Volume = 25;
radio.Station = 101.5;
radio.Station = 25;  //should not set
radio.Display();
Console.WriteLine();

Hummingbird hummingbird = new Hummingbird();

// Logger logger;
// hummingbird.EarsCount
Console.WriteLine($"{typeof(Hummingbird).Name} has - ");

foreach(var property in typeof(Hummingbird).GetProperties())
{
    // property.GetValue(hummingbird);
    Console.WriteLine($"{property.Name} is {property.GetValue(hummingbird)}");
}

// Parallel.ForEach(hummingbird.GetType().GetProperties(), type_ => Console.WriteLine($" is - {type_}"));