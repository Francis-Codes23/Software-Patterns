using CommandPattern.Command_Pattern;
using System;

namespace COC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerSupport order = new OrderSupport();
            CustomerSupport del = new DeliverySupport();
            CustomerSupport pay = new PaymentSupport();
            CustomerSupport tech = new TechnicalSupport();
            order.SetNextSupport(del).SetNextSupport(tech).SetNextSupport(pay);
            order.Handle(new Request("Payment", "How do I pay for returned orders?"));
            order.Handle(new Request("Delivery", "When will my order be delivered?"));
            order.Handle(new Request("Technical", "I cant navigate your website"));
            order.Handle(new Request("Selling", "I am selling my appliances, dont you wanna buy?"));
            Console.ReadKey();
            ///
            Fan fan = new Fan();
            ICommand command = new TurnFanOnCommand(fan);
            CommandInvoker invoker = new CommandInvoker();
            invoker.SetCommand(command);
            invoker.Invoke();
            Console.ReadKey();
        }
    }
}
