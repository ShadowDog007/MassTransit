namespace MassTransit
{
    using System;


    public interface IOutboxOptionsConfigurator
    {
        /// <summary>
        /// The number of messages to deliver at a time from the outbox to the broker
        /// </summary>
        public int MessageDeliveryLimit { set; }

        /// <summary>
        /// Transport Send timeout when delivering messages to the transport
        /// </summary>
        TimeSpan MessageDeliveryTimeout { set; }

        /// <summary>
        /// Set to true if messages can be delivered to the broker concurrently. Concurrent delivery is faster, but does not match the order of the
        /// original publish/respond/send calls. Defaults to false to match existing behavior.
        ///
        /// When true, delivers messages in batches of <see cref="MessageDeliveryLimit"/>
        /// </summary>
        bool ConcurrentMessageDelivery { set; }
    }
}
