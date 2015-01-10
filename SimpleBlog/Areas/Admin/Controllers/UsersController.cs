using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            return Content("USERS!");
        }
    }
}
