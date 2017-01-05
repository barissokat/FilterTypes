using FilterTypes.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterTypes.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        [Log]
        [HandleError(ExceptionType = typeof(FormatException), View = "FormatError")]
        public ActionResult Index()
        {
            throw new FormatException();
        }
    }
}