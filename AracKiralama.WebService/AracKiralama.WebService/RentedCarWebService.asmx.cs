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
    /// Summary description for RentedCarWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RentedCarWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public RentedCar[] GetAll()
        {
            try
            {
                using (var c = new RentedCarBusiness())
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
        public bool Update(RentedCar car)
        {
            try
            {
                using (var u = new RentedCarBusiness())
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
        [WebMethod]
        public bool Insert(RentedCar car)
        {
            try
            {
                using (var u = new RentedCarBusiness())
                {
                    return u.Insert(car);
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
