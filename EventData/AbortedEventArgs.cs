﻿using System;

namespace XModemProtocol.EventData {
    /// <summary>
    /// Provides data for the XModemProtocol.XModemCommunicator.Aborted event.
    /// </summary>
    public class AbortedEventArgs : EventArgs {
        /// <summary>
        /// Reason for abort.
        /// </summary>
        public XModemAbortReason Reason { get; private set; }
        internal AbortedEventArgs(XModemAbortReason reason) {
            Reason = reason;
        }
    }
}