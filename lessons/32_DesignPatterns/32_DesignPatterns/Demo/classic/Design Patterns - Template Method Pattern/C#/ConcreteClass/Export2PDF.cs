using System;

namespace BehavioralPattern_TemplateMethod
{
    class Export2PDF : DataExporter
    {
        public override void FormatData()
        {
            Console.WriteLine("Export2PDF - Concrete Implementation of DataExporter.FormatData() Method");
            Console.WriteLine("Export2PDF - Formatting data to Export to Excel");
        }

        public override void Process()
        {
            Console.WriteLine("Export2PDF - Concrete Implementation of DataExporter.Process() Method");
            Console.WriteLine("Export2PDF - Processing data to Export to Excel");
        }
    }
}