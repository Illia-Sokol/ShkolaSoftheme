namespace _03_Explicitly_implementing
{
    class Program
    {
        static void Main()
        {
            var mySmartPhone = new SmartPhone();

            mySmartPhone.Call("123-123-123");
            mySmartPhone.TakePicture();

            ((IGameConsole)mySmartPhone).Play("Super Mario");

            ((IPlayer)mySmartPhone).Play("We_are_the_champions.mp3");
        }
    }
}
