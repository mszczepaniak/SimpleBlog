using System.Web.Mvc;
using System.Web.Security;
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

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("home");
        }
        // here goes post request
        [HttpPost]
        public ActionResult Login(AuthLogin form, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }
            // this is the authentication
            // this is how we say to the asp.net that the person is who he tells he is 
            FormsAuthentication.SetAuthCookie(form.Username, true);
            if (!string.IsNullOrWhiteSpace(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToRoute("home");
        }
    }
}
