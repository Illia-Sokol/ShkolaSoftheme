using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile
{
    class CallInfo
    {
        public int Sender { get; set; }
        public int Receiver { get; set; }
    }
    class MobileAccount
    {
        private readonly int _number;

        public event EventHandler<CallInfo> SendCall ;
        }
}
