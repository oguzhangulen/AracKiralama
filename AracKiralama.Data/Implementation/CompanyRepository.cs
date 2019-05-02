using AracKiralama.Data.Context;
using AracKiralama.Data.Infrastructure;
using AracKiralama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Data.Implementation
{
    public class CompanyRepository : ICompanyRepository,IDisposable
    {
        private readonly DataContext _context;
        public CompanyRepository()
        {
            _context = new DataContext();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public IEnumerable<Company> GetAll()
        {
            return _context.Companies.ToList();
        }

        public Company GetById(int id)
        {
            return _context.Companies.Where(s => s.Id == id).FirstOrDefault();
        }

        public void Insert(Company obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Company obj)
        {
            throw new NotImplementedException();
        }
    }
}
