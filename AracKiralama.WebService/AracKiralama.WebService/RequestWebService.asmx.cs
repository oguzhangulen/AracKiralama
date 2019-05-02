using AracKiralama.Business.Concretes;
using AracKiralama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AracKiralama.WebService
{
    /// <summary>
    /// Summary description for RequestWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RequestWebService : System.Web.Services.WebService
    {


        [WebMethod]
        public Request[] GetAll()
        {
            try
            {
                using (var c = new RequestBusiness())
                {
                    return c.GetAll().ToArray();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        [WebMethod]
        public bool Delete(Request request)
        {
            try
            {
                using (var u = new RequestBusiness())
                {
                    return u.Delete(request);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        [WebMethod]
        public bool Insert(Request request)
        {
            try
            {
                using (var u = new RequestBusiness())
                {
                    u.Insert(request);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
