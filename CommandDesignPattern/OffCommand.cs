using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    internal class OffCommand : ICommand
    {
        Television TV { get; set; }
        public OffCommand(Television tv)
        {
            TV = tv;
        }
        public void Execute()
        {
            TV.Off();
        }
    }
}
