namespace _03_Generics
{
    public interface IDocument
    {
        string Name { get; set; }

        string Header { get; set; }

        string Body { get; set; }

        string Footer { get; set; }

        string GetAllInfo();
    }
}