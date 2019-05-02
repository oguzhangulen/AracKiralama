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
    public class RequestRepository : IRequestRepository,IDisposable
    {
        private readonly DataContext _context = new DataContext();
        public RequestRepository()
        {
            
        }

        public void Delete(Request obj)
        {
            if (obj != null)
                _context.Entry(obj).State = EntityState.Deleted;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public IEnumerable<Request> GetAll()
        {
            return _context.Requests.ToList();
        }

        public Request GetById(int id)
        {
            return _context.Requests.Where(s => s.Id == id).FirstOrDefault();
        }

        public void Insert(Request obj)
        {
            _context.Requests.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Request obj)
        {
            throw new NotImplementedException();
        }
    }
}
