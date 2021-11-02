namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            DataExporter exporter = null;

            exporter = new ExcelExporter();
            exporter.ExportFormattedData();

            exporter = new PDFExporter();
            exporter.ExportFormattedData();
        }
    }
}
