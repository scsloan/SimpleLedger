namespace SimpleLedger.WebApplication.Models.Reports
{
    public class ReportIndexModel
    {
        public List<string> Categories { get; set; }
        
        public ReportIndexModel()
        {
            Categories = new List<string>();
        }

    }
}
