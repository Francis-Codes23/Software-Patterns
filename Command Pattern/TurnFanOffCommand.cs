namespace CommandPattern.Command_Pattern
{
    internal class TurnFanOffCommand:ICommand
    {
        private Fan fan;
        public TurnFanOffCommand(Fan fan)
        {
            this.fan = fan;
        }
        public void Execute()
        {
            fan.TurnOff();
        }

    }
}
