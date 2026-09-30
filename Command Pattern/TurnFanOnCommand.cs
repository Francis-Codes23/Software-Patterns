namespace CommandPattern.Command_Pattern
{
    internal class TurnFanOnCommand:ICommand
    {
        private Fan _fan;

        public TurnFanOnCommand(Fan fan)
        {
            _fan = fan;
        }
        public void Execute()
        {
            _fan.TurnOn();
        }
    }
}
