using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldClasses.User
{
    public interface ICommand
    {
       public void Execute(); 
       /*

       public void MoveRight(); 

       public void MoveLeft(); 

       public void MoveUp(); 

       public void MoveDown(); 

       public void X(); 

       public void Y(); 

       public void A(); 

       public void B(); 

       public void Start(); 

       public void Select(); */
    }
}