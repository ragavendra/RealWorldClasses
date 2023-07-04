using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldClasses.Area
{
    public interface IArea
    {
        public Coordinates Location { get; }
    }

    public record Coordinates
    {
        public double Latitude;

        public double Longitude;
    }
}