using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracKiralama.WebUI.CarWebService;
using AracKiralama.WebUI.RentedCarWebService;

namespace AracKiralama.WebUI.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index(int? id)
        {
            CarWebServiceSoapClient carWebService = new CarWebServiceSoapClient();
            IList<Car> tempList = carWebService.GetAll().Where(s=>s.CompanyId==id).ToList();
            return View(tempList);
        }
        public ActionResult CarRequest(AracKiralama.WebUI.CarWebService.Car car)
        {
            var request = new AracKiralama.WebUI.RentedCarWebService.RentedCar();
            request.carId = car.Id;
            return View(request);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CarRequest(AracKiralama.WebUI.RentedCarWebService.RentedCar request)
        {
            RentedCarWebServiceSoapClient rentedWebService = new RentedCarWebServiceSoapClient();
            RentedCarWebService.RentedCar requ = new RentedCarWebService.RentedCar();
            requ.carId = request.carId;
            requ.CustomerName = request.CustomerName;
            requ.CustomerSurname = request.CustomerSurname;
            requ.CustomerTC = request.CustomerTC;
            requ.DeliveryDate = request.DeliveryDate;
            requ.RentDate = request.RentDate;
            if (rentedWebService.Insert(requ) == true)
            {
                CarWebServiceSoapClient carWebService = new CarWebServiceSoapClient();
                var temp = carWebService.GetAll().Where(s => s.Id == request.carId).FirstOrDefault();
                temp.IsAvailable = false;
                carWebService.Update(temp);
                return RedirectToAction("Index");
            }
            else
            {
                CarWebServiceSoapClient carWebService = new CarWebServiceSoapClient();
                var car = carWebService.GetAll().Where(s => s.Id == request.carId).FirstOrDefault();
                return RedirectToAction("CarRequest", car);
            }
        }
    }
}