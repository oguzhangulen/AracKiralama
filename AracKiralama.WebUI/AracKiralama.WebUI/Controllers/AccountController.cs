using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AracKiralama.WebUI.UserWebService;
using Newtonsoft.Json;

namespace AracKiralama.WebUI.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Models.LoginModel customer, string ReturnUrl = "")
        {
            UserWebServiceSoapClient userWebService = new UserWebServiceSoapClient();
            var UserExist = userWebService.GetAll().Where(s => s.Username == customer.UserName).FirstOrDefault();
            if (UserExist != null)
            {
                if (ModelState.IsValid)
                {
                    //TODO : Kontrol Et 
                    if (string.Compare((customer.Password), UserExist.Password) == 0)
                    {
                        string userjson = JsonConvert.SerializeObject(UserExist);
                        if (!string.IsNullOrEmpty(ReturnUrl))
                            return Redirect(ReturnUrl);
                        FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(
                            1, UserExist.Username, DateTime.Now, DateTime.Now.AddMinutes(30), false, userjson
                            );
                        string enTicket = FormsAuthentication.Encrypt(authTicket);
                        HttpCookie faCookie = new HttpCookie("RentCookie", enTicket);
                        Response.Cookies.Add(faCookie);
                        if (Url.IsLocalUrl(ReturnUrl))
                        {
                            return Redirect(ReturnUrl);
                        }
                        else
                        {
                                return RedirectToAction("Index", "User",(int)UserExist.CompanyId);
                        }


                    }
                    else
                    {
                        ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı!");
                        return View(customer);
                    }
                }
            }
            ModelState.AddModelError("", "Kullanıcı adı veya Şifre Hatalı");
            return View(customer);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            foreach (var cookie in Request.Cookies.AllKeys)
            {
                Request.Cookies.Remove(cookie);
            }
            if (Request.Cookies["RentCookie"] != null)
            {
                var c = new HttpCookie("RentCookie");
                c.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(c);
            }
            return RedirectToAction("Login", "Account");
        }
    }
}