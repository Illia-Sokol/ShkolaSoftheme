namespace Events
{
    internal class AccountEventArgs 
    {
        public string Message { get; set; }

        public int Sum { get; set; }

        public AccountEventArgs(string message, int sum)
        {
            Message = message;
            Sum = sum;
        }
    }
}