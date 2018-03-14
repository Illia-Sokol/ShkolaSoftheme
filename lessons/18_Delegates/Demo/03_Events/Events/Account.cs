using System;

namespace Events
{
    internal class Account
    {
        public delegate void AccountStateHandler(object sender, AccountEventArgs e);

        public event AccountStateHandler Withdrowed;
        public event AccountStateHandler Added;

        private int _sum;
        private int _percentage;

        public Account(int sum, int percentage)
        {
            _sum = sum;
            _percentage = percentage;
        }

        public int CurrentSum
        {
            get { return _sum; }
        }

        public void Put(int sum)
        {
            _sum += sum;
            if (Added != null)
                Added((object)this, new AccountEventArgs(string.Format("Next sum was added to the account: {0}", sum), sum));
        }
        public void Withdraw(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;
                if (Withdrowed != null)
                    Withdrowed(this, new AccountEventArgs(string.Format("Sum: {0} was removed from the account", sum), sum));
            }
            else
            {
                if (Withdrowed != null)
                    Withdrowed(this, new AccountEventArgs("Not enough money in the account", sum));
            }
        }

        public int Percentage
        {
            get { return _percentage; }
        }
    }
}