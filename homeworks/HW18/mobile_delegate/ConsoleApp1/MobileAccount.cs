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

        public delegate void CallHandler(object sender, EventHandler e);
        public event EventHandler<CallInfo> SendCall;

        public MobileAccount(int number)
        {
            _number = number;
        }

        public void Call(int sum)
        {
            Console.WriteLine("call");
        }

        public void SendSms()
        {
            Console.WriteLine("sendSmS");
        }
    }
}
