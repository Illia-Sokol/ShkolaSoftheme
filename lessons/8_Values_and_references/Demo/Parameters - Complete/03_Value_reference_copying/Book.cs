namespace _03_Value_reference_copying
{
    public class Book
    {
        public Book(string name, string author, int pages)
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