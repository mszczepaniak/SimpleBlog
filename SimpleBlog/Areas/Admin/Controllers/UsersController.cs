using System.Web.Mvc;
using SimpleBlog.Infrastructure;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        [Authorize(Roles = "admin")]
        [SelectedTab("users")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
