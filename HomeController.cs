using ProgressTask.Model;
using System.Web.Mvc;

namespace ProgressDisplay.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult InvokeCounterMethod(int value)
        {
            ProgressMeterModel model = new ProgressMeterModel();
            ProgressResults.Counter(model, value);

            return null;
        }
    }
}
