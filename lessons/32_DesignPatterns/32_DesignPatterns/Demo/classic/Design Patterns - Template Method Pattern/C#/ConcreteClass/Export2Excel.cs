using System;

namespace BehavioralPattern_TemplateMethod
{
    class Export2Excel : DataExporter
    {
        public override void FormatData()
        {
            Console.WriteLine("Export2Excel - Concrete Implementation of DataExporter.FormatData() Method");
            Console.WriteLine("Export2Excel - Formatting data to Export to Excel");
        }

        public override void Process()
        {
            Console.WriteLine("Export2Excel - Concrete Implementation of DataExporter.Process() Method");
            Console.WriteLine("Export2Excel - Processing data to Export to Excel");
        }
    }
}