namespace Solid
{
    public class ReportGenerator
    {
	// This class violates the 'Open/Closed' principle
    	// What if we wanted to add a report type?
		
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
