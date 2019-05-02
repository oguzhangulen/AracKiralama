using AracKiralama.Data.Implementation;
using AracKiralama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Business.Concretes
{
    public class CarBusiness : IDisposable
    {
        public IList<Car> GetAll()
        {
            try
            {
                using (var c = new CarRepository())
                {
                    var tempList = c.GetAll();
                    return tempList.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public bool Update(Car car)
        {
            try
            {
                using (var c = new CarRepository())
                {
                    c.Update(car);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public Car GetById(int id)
        {
            try
            {
                using (var c = new CarRepository())
                {
                    var car = c.GetById(id);
                    return (Car)car;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public CarBusiness()
        {

        }
    }
}
