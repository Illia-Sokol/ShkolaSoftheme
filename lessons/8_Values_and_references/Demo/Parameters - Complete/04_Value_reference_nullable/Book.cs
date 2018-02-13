namespace _04_Value_reference_nullable
{
    public class Book
    {
        public Book(string name, string author, int pages = default(int))
        {
            Name = name;
            Author = author;
            Pages = pages;
        }

        public int Pages { get; set; }

        public string Author { get; set; }

        public string Name { get; set; }
    }
}