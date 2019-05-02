using AracKiralama.Data.Implementation;
using AracKiralama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Business.Concretes
{
    public class CompanyBusiness:IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public IList<Company> GetAll()
        {
            try
            {
                using (var company = new CompanyRepository())
                {
                    var tempList = company.GetAll();
                    return tempList.ToList();
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
