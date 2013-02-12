using System;
using NServiceBus;
using Orders.Messages;

namespace Orders.Handler
{
    public class MessageHandler: IHandleMessages<TestOrderEvent>
    {
        public void Handle(TestOrderEvent message)
        {
            Console.WriteLine("Got Test order event for orderId [{0}].", message.OrderId);
        }
    }
}