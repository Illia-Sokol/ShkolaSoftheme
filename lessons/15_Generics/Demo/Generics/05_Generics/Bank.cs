namespace _05_Generics
{
    public class Bank<T> : IBank<T>
           where T : Account
    {
        public void DoOperation(T account)
        {
            account.DoTransfer();
        }
    }
}