﻿using System;

namespace XModemProtocol.Operations.Invoke {
    using Options;
    using EventData;
    public interface IInvoker {
        void Invoke(ISendReceiveRequirements requirements);
        event EventHandler<PacketToSendEventArgs> PacketToSend;
        event EventHandler<PacketReceivedEventArgs> PacketReceived;
    }
}