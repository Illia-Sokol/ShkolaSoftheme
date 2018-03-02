namespace _03_Generics
{
    class PdfDocument : IDocument
    {
        public string Name { get; set; }

        public string Header { get; set; }

        public string Body { get; set; }

        public string Footer { get; set; }

        public string GetAllInfo()
        {
            return string.Format("PDF document '{0}'\n {1} \n {2} ", Name, Header, Footer);
        }
    }
}