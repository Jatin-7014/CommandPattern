namespace CommandDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Television tv= new Television();
            ICommand onCommand=new OnCommand(tv);
            RemoteControl remote=new RemoteControl(onCommand);
            remote.PressButton();
            ICommand offCommand = new OffCommand(tv);
            remote.setCommand(offCommand);
            //remote = new RemoteControl(offCommand);
            remote.PressButton();
        }
    }
}
