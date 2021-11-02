using System;

namespace Template
{
    public class ExcelExporter : DataExporter
    {
        public override void ExportData()
        {
            Console.WriteLine("Exporting the data to an Excel file.");
        }
    }
}
