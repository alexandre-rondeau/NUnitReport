using Solirus.NUnitReport.Presentation.Models.TestResultModels;

namespace Solirus.NUnitReport.Presentation.Models.HomeModels
{
    public class IndexHomeModel
    {
        public AddTestResultModel AddTestResult { get; set; }

        public IndexHomeModel()
        {
            AddTestResult = new AddTestResultModel();
        }
    }
}