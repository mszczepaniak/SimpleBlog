using System.Web.Mvc;

namespace SimpleBlog.Infrastructure
{
    public class TransactionFilter : IActionFilter
    {
        // we create the filter
        // happens when the action begins
        public void OnActionExecuting(ActionExecutingContext filterContext)
        { 
            Database.Session.BeginTransaction();
        }
        // happens when the action is finished
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            // if there was no exception thrown by the action
            if (filterContext.Exception == null)
            {
                Database.Session.Transaction.Commit();
            }
            //otherwise rollback the changes 
            else
            {
                Database.Session.Transaction.Rollback();
            }
        }
    }
}