using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AracKiralama.Business.Concretes;
using AracKiralama.Models;

namespace AracKiralama.WebService
{
    /// <summary>
    /// Summary description for CarWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CarWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public Car[] GetAll()
        {
            try
            {
                using (var c = new CarBusiness())
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
        public bool Update(Car car)
        {
            try
            {
                using (var u = new CarBusiness())
                {
                    return u.Update(car);
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
