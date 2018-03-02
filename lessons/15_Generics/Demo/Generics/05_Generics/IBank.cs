namespace _05_Generics
{
    public interface IBank<in T>
               where T : Account
    {
        void DoOperation(T account);
    }
}