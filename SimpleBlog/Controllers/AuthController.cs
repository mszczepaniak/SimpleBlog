using System.Web.Mvc;
using SimpleBlog.ViewModels;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        // here goes get request
        [HttpGet]
        public ActionResult Login()
        {
            return View(new AuthLogin
            {
            });
        }
        // here goes post request
        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }
            if (form.Username != "rainbow dash")
            {
                ModelState.AddModelError("Username", "Username or password isn't 20% cooler.");
                return View(form);
            }
            return Content("The form is valid!");
        }
    }
}
