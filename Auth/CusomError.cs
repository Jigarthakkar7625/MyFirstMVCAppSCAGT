using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace MyFirstMVCAppSCAGT.Auth
{

    //public class CusomErrorAttribute : FilterAttribute, IExceptionFilter
    public class CusomErrorAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                // Database insert :

                filterContext.ExceptionHandled = true;
                
                filterContext.Result = new ViewResult()
                {
                    ViewName = "Error",
                };

                ViewResult viewResult = filterContext.Result as ViewResult;
                viewResult.ViewBag.Error = filterContext.Exception.Message;
                
                //    filterContext.Result = new ViewResult()
                //    {
                //        ViewName = "Error",
                //        //ViewBag.ErrCode = 500
                //        ViewData["jigar"] = "jiar";
                //};
            }

        }

        // Insert into database
        //throw new NotImplementedException();
    }
}
