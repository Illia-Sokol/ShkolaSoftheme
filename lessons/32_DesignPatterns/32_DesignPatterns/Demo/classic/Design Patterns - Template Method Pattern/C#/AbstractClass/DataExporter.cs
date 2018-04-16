using System;

namespace BehavioralPattern_TemplateMethod
{
    abstract class DataExporter
    {
        //1. Common functionality which is required for all Sub/Dervied Classes (Concrete classes)
        public virtual void Connect()
        {
            Console.WriteLine("\nDataExporter - Connect() Virtual Method");
        }

        public virtual void Disconnect()
        {
            Console.WriteLine("DataExporter - Disconnect() Virtual Method");
        }
        
        //2. Sub classes can implement their own logic for these methods.
        public abstract void FormatData();
        public abstract void Process();

        //3. The 'Template Method'. The main alogrithm defined and handled for all Sub Classes (Concrete classes)
        //  Provides the mail skeleton for execution of the algorithm.
        public void Export()
        {
            Connect();
            FormatData();
            Process();
            Disconnect();
            Console.WriteLine("Export Successful.");
        }
    }
}