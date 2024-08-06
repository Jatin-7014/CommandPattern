using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    internal class Television
    {
        public void On()
        {
            Console.WriteLine("Television is turned ON......");
        }
        public void Off() 
        {
            Console.WriteLine("Television is turned OFF......");
        }
    }
}
