using AracKiralama.Data.Context;
using AracKiralama.Data.Infrastructure;
using AracKiralama.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Data.Implementation
{
    public class RentedCarRepository : IRentedCarRepository
    {
        private readonly DataContext _context;
        public RentedCarRepository()
        {
            _context = new DataContext();
        }

        public IEnumerable<RentedCar> GetAll()
        {
            return _context.RentedCars.Where(s => s.IsActive == true).Select(x => x);
        }

        public RentedCar GetById(int id)
        {
            return _context.RentedCars.Where(s => s.Id == id).FirstOrDefault();
        }

        public void Insert(RentedCar obj)
        {
            _context.RentedCars.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(RentedCar obj)
        {
            if(obj!=null)
            _context.Entry(obj).State=EntityState.Modified;
        }
    }
}
