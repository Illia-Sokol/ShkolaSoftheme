using System;

namespace BehavioralPattern_TemplateMethod
{
    class Program
    {
        static void Main()
        {
            DataExporter DataExporterExport2Excel = new Export2Excel();
            DataExporterExport2Excel.Export();

            DataExporter DataExporterExport2PDF = new Export2PDF();
            DataExporterExport2PDF.Export();

            Console.ReadLine();
        }
    }
}