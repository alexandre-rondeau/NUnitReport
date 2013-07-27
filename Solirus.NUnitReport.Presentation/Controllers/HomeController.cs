using System.Web.Mvc;
using Solirus.NUnitReport.Presentation.Models.HomeModels;

namespace Solirus.NUnitReport.Presentation.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new IndexHomeModel();
            return View("Index", model);
        }

    }
}