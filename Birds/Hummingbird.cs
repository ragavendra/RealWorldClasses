using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldClasses.Birds
{
    public class Hummingbird : IBird
    {
        bool IBird.Fly { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IAnimal.EyesCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IAnimal.EarsCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IAnimal.NoseCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IAnimal.MouthCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IAnimal.LegsCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IAnimal.HasTail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}