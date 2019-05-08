using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AracKiralama.WebUI.Models.Attribute
{
    public class LoginControl : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContextWrapper wrapper = new HttpContextWrapper(HttpContext.Current);
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
            {
                if (!HttpContext.Current.Response.IsRequestBeingRedirected)
                    filterContext.Result = new RedirectToRouteResult(
                        new System.Web.Routing.RouteValueDictionary(
                            new
                            {
                                action = "Login",
                                Controller = "Account"
                            }));
                filterContext.Result = new RedirectToRouteResult(
                        new System.Web.Routing.RouteValueDictionary(
                            new
                            {
                                action = "Login",
                                Controller = "Account"
                            }));
            }
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            HttpContextWrapper wrapper = new HttpContextWrapper(HttpContext.Current);
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
            {
                context.Result = new RedirectToRouteResult(
                    new System.Web.Routing.RouteValueDictionary(
                        new
                        {
                            action = "Login",
                            Controller = "Account"
                        }));
            }
        }
    }
}