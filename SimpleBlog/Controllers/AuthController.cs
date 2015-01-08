using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
    }
}
