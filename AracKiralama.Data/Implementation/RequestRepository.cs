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
    public class RequestRepository : IRequestRepository
    {
        private readonly DataContext _context;
        public RequestRepository()
        {
            _context = new DataContext();
        }

        public void Delete(Request obj)
        {
            if (obj != null)
                _context.Entry(obj).State = EntityState.Deleted;
        }

        public IEnumerable<Request> GetAll()
        {
            return _context.Requests.Select(s => s);
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
