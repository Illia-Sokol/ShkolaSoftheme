using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobile
{
    class MobileOperator : IDisposable
    {
        private readonly List<MobileAccount> accounts = new List<MobileAccount>();

        public void AddAccount(MobileAccount account)
        {
            account.CallIssued += Account_CallReceived;
            account.SmsSent += Account_SmsReceived;
            accounts.Add(account);
        }

        private void Account_SmsReceived(object sender, SmsInfoEventArgs e)
        {
            var receiver = accounts.FirstOrDefault(a => a.Number == e.Receiver);
            if (receiver != null)
            {
                receiver.ReceiveSms(e.Sender, e.Message);
            }
        }

        private void Account_CallReceived(object sender, CallInfoEventArgs e)
        {
            var receiver = accounts.FirstOrDefault(a => a.Number == e.Receiver);
            if (receiver != null)
            {
                receiver.ReceiveCall(e.Sender);
            }
        }

        public void Dispose()
        {
            foreach (var account in accounts)
            {
                account.CallIssued -= Account_CallReceived;
                account.SmsSent -= Account_SmsReceived;
            }
            accounts.Clear();
        }
    }
}
