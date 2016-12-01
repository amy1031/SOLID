namespace Solid
{
    public class ReportGenerator
    {
		// this class violates the 'Open/Closed' principle
		
        public string ReportType { get; set; }

        public void GenerateReport(Employee employee)
        {
            if (ReportType == "CRS")
            {
                // Report generation with employee data in Crystal Report.
            }

            if (ReportType == "PDF")
            {
                // Report generation with employee data in PDF.
            }
        }
    }
}