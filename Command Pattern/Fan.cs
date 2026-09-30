using System;

namespace CommandPattern.Command_Pattern
{
    internal class Fan
    {
        public void TurnOn()
        {
            Console.WriteLine("Fan is now on.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Fan is now off.");
        }
    }
}
