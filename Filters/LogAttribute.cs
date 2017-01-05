using FilterTypes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterTypes.Filters
{
    public class LogAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            LogsData.Logs.Add(new Models.Log
            {
                Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Action = filterContext.ActionDescriptor.ActionName,
                ProcessDate = DateTime.Now,
                Type = "After"
            });
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            LogsData.Logs.Add(new Models.Log
            {
                Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Action = filterContext.ActionDescriptor.ActionName,
                ProcessDate = DateTime.Now,
                Type = "Before"
            });
        }
    }
}