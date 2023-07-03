using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldClasses.User
{
    public interface ICommand
    {
       public void Execute(); 
    }
}