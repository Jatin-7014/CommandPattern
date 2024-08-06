using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    internal class RemoteControl
    {
        ICommand Command {  get; set; }
       
        public RemoteControl(ICommand command)
        {
            Command = command;
        }
        public void PressButton()
        {
            Command.Execute();
        }
        public void setCommand(ICommand command)
        {
            Command = command;
        }

    }
}
