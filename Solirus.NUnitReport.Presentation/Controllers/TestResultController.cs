using System.Web.Mvc;
using Resources;
using Solirus.NUnitReport.Database.Context;
using Solirus.NUnitReport.Database.Model;
using Solirus.NUnitReport.Presentation.Models.TestResultModels;

namespace Solirus.NUnitReport.Presentation.Controllers
{
    public class TestResultController : Controller
    {
        [HttpGet]
        public ActionResult Add()
        {
            var model = new AddTestResultModel();
            return PartialView("AddTestResultModel", model);
        }

        [HttpPost]
        public ActionResult Add(AddTestResultModel model)
        {
            if (ModelState.IsValid && model.TestResultFile != null)
            {
                if (model.TestResultFile.ContentType == "text/xml")
                {
                    //var testResult = new TestResult
                    //                     {
                    //                             Content = System.Text.Encoding.Default.GetString(model.TestResultFile.InputStream.ReadToEnd())
                    //                     };
                    //using (var context = new NUnitReportDbContext())
                    //{
                    //    context.TestResults.Add(testResult);
                    //    context.SaveChanges();
                    //}
                    return Add();
                }
                ModelState.AddModelError("TestResultFile", Global.NotAValidTestResultFile);
            }
            return PartialView("AddTestResultModel", model);
        }
    }
}
