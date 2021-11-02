using System;

namespace Template
{
    public abstract class DataExporter
    {
        public void ReadData()
        {
            Console.WriteLine("Reading the data from SqlServer.");
        }

        public void FormatData()
        {
            Console.WriteLine("Formatting the data as per requirements.");
        }

        public abstract void ExportData();

        public void ExportFormattedData()
        {
            ReadData();
            FormatData();
            ExportData();
        }
    }
}
