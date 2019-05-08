using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracKiralama.WebUI.UserWebService;
using AracKiralama.WebUI.CarWebService;
using AracKiralama.Models;
using AracKiralama.WebUI.RequestWebService;

namespace AracKiralama.WebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            CarWebServiceSoapClient carWebService = new CarWebServiceSoapClient();
            IList<CarWebService.Car> tempList = carWebService.GetAll().Where(s => s.IsAvailable == true).ToList();
            return View(tempList);
        }
        public ActionResult CarRequest(AracKiralama.WebUI.CarWebService.Car car)
        {
            var request = new AracKiralama.WebUI.RequestWebService.Request();
            request.CarId = car.Id;
            return View(request);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CarRequest(AracKiralama.WebUI.RequestWebService.Request request)
        {
            RequestWebServiceSoapClient requestWebService = new RequestWebServiceSoapClient();
            RequestWebService.Request requ = new RequestWebService.Request();
            requ.CarId = request.CarId;
            requ.CustomerName = request.CustomerName;
            requ.CustomerSurname = request.CustomerSurname;
            requ.CustomerTC = request.CustomerTC;
            requ.DeliveryDate = request.DeliveryDate;
            requ.RentDate = request.RentDate;
            if (requestWebService.Insert(requ) == true)
                return RedirectToAction("Index");
            else
            {
                CarWebServiceSoapClient carWebService = new CarWebServiceSoapClient();
                var car = carWebService.GetAll().Where(s => s.Id == request.CarId).FirstOrDefault();
                return RedirectToAction("CarRequest",car);//car gönderilecek
            }
        }
    }
}