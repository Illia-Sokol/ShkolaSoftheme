namespace _04_Generics
{
    //public interface IContainer<out T> - covariant parameter
    public interface IContainer<out T>
    {
        T GetItem();
    }
}