using System.Linq;
using System.Web.Mvc;
using NHibernate.Linq;
using SimpleBlog.Areas.Admin.ViewModels;
using SimpleBlog.Infrastructure;
using SimpleBlog.Models;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        [Authorize(Roles = "admin")]
        [SelectedTab("users")]
        public ActionResult Index()
        {
            // tell nhibernate to get data, stuff it to the viewmodel
            // and then hand it off to the view
            return View(new UsersIndex
            {
                // we want to turn this query to the collection of objects in the memory
                Users = Database.Session.Query<User>().ToList()
            });
        }

        public ActionResult New()
        {
            return View(new UsersNew {});
        }
    }
}
