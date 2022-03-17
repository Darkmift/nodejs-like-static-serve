using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           return new FilePathResult("~/Public/index.html", "text/html");
        }
    }
}
