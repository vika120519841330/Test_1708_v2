using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TEST_170819.Context;
using TEST_170819.Interfaces;
using TEST_170819.Models;
using TEST_170819.Services;

namespace TEST_170819.Filters
{
    public class FilterFixRequestAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
           
        }
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                FixRequest fixRequest = new FixRequest()
                {
                    UserName = HttpContext.Current.User.Identity.Name,
                    ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                    ActionName = filterContext.ActionDescriptor.ActionName,
                    GetDateTime = DateTime.Now,
                    CorrelationId = Guid.NewGuid().ToString()
                };
                using (IRequestRepository logService = new RequestRepository(new MyContext()))
                {
                    logService.FixLog(fixRequest);
                }
            }
        }
    }
}