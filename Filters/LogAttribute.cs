using FilterTypes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterTypes.Filters
{
    public class LogAttribute : FilterAttribute, IActionFilter, IResultFilter, IExceptionFilter
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

        public void OnException(ExceptionContext filterContext)
        {
            LogsData.Logs.Add(new Models.Log
            {
                Controller = filterContext.RouteData.Values["controller"].ToString(),
                Action = filterContext.RouteData.Values["action"].ToString(),
                ProcessDate = DateTime.Now,
                Type = "Error",
                ErrorMessage = filterContext.Exception.Message
            });
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            LogsData.Logs.Add(new Models.Log
            {
                Controller = filterContext.RouteData.Values["controller"].ToString(),
                Action = filterContext.RouteData.Values["action"].ToString(),
                ProcessDate = DateTime.Now,
                Type = "After Result"
            });
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            LogsData.Logs.Add(new Models.Log
            {
                Controller = filterContext.RouteData.Values["controller"].ToString(),
                Action = filterContext.RouteData.Values["action"].ToString(),
                ProcessDate = DateTime.Now,
                Type = "Before Result"
            });
        }
    }
}