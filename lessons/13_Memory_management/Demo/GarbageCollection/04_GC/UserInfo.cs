namespace _04_GC
{
    class UserInfo
    {
        public string Name { set; get; }
        public int Age { set; get; }

        public UserInfo(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}