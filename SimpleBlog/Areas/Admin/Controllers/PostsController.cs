using System.Web.Mvc;
using SimpleBlog.Infrastructure;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class PostsController : Controller
    {
        [Authorize(Roles = "admin")]
        [SelectedTab("posts")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
