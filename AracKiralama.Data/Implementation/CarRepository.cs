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
    public class CarRepository : ICarRepository,IDisposable
    {
        private readonly DataContext _context;

        public CarRepository()
        {
            _context = new DataContext();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetAll()
        {
            return _context.Cars.ToList();
        }

        public Car GetById(int id)
        {
            return _context.Cars.Where(s => s.Id == id).FirstOrDefault();
        }

        public void Insert(Car obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Car obj)
        {
            if(obj!=null)
            _context.Entry(obj).State = EntityState.Modified;
        }
    }
}
