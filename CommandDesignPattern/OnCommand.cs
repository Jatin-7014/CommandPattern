using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    internal class OnCommand : ICommand
    {
        Television TV { get; set; }
        public OnCommand(Television tv)
        {
            TV = tv;
        }
        public void Execute()
        {
            TV.On();
        }
    }
}
