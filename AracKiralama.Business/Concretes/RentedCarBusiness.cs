using AracKiralama.Data.Implementation;
using AracKiralama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Business.Concretes
{
    public class RentedCarBusiness : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
        public IList<RentedCar> GetAll()
        {
            try
            {
                using (var r = new RentedCarRepository())
                {
                    var tempList = r.GetAll();
                    return tempList.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public RentedCar GetById(int id)
        {
            try
            {
                using (var r = new RentedCarRepository())
                {
                    var car = r.GetById(id);
                    return car;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public bool Update(RentedCar rentedCar)
        {
            try
            {
                using (var r=new RentedCarRepository())
                {
                    r.Update(rentedCar);
                    r.Save();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public bool Insert(RentedCar rentedCar)
        {
            try
            {
                using (var r = new RentedCarRepository())
                {
                    r.Insert(rentedCar);
                    r.Save();
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
