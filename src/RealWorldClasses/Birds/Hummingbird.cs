using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealWorldClasses.Kingdom.Animals;

namespace RealWorldClasses.Birds
{
    public class Hummingbird : Bird
    {
        #region Hummingbird specific

        private int _legsHeight = 3;

        private int _tailLength = 6;

        private int _beakLength = 1;

        #endregion

        public override int LegsHeight { get => _legsHeight; set => _legsHeight = value; }

        public override int TailLength { get => _tailLength; set => _tailLength = value; }

        public override int BeakLength { get => _beakLength; set => _beakLength = value; }
    }
}