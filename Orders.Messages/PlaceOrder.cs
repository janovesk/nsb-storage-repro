using System;
using System.Text;
using NServiceBus;

namespace Orders.Messages
{
    public class TestOrderEvent : IEvent
    {
        public string OrderId { get; set; }
    }
}
