using AracKiralama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AracKiralama.Business.Concretes;

namespace AracKiralama.WebService
{
    /// <summary>
    /// Summary description for CompanyWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CompanyWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public Company[] GetAll()
        {
            try
            {
                using (var c = new CompanyBusiness())
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
    }
}
