namespace CommandPattern.Command_Pattern
{
    internal class CommandInvoker
    {
        private ICommand _command;
        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public void Invoke()
        {
            _command.Execute();

        }
    }
}
