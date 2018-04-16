using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile
{
    class CallInfoEventArgs : EventArgs
    {
        public int Sender { get; set; }
        public int Receiver { get; set; }
    }

    class SmsInfoEventArgs : EventArgs
    {
        public int Sender { get; set; }
        public int Receiver { get; set; }
        public string Message { get; set; }
    }

    class MobileAccount
    {
        public int Number { get; }

        public event EventHandler<CallInfoEventArgs> CallIssued;
        public event EventHandler<SmsInfoEventArgs> SmsSent;

        public MobileAccount(int number)
        {
            Number = number;
        }

        public void Call(int number)
        {
            var callIssued = CallIssued;
            if (callIssued != null)
            {
                callIssued(this, new CallInfoEventArgs { Sender = Number, Receiver = number });
            }
        }

        public void SendSms(int number, string message)
        {
            var smsSent = SmsSent;
            if (smsSent != null)
            {
                smsSent(this, new SmsInfoEventArgs { Sender = Number, Receiver = number, Message = message });
            }
        }

        public void ReceiveCall(int number)
        {
            Console.WriteLine($"{Number}: Call from account {number}");
        }

        public void ReceiveSms(int number, string message)
        {
            Console.WriteLine($@"{Number}: Received message ""{message}"" from {number}");
        }
    }
}
