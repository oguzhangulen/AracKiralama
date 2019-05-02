using AracKiralama.Data.Implementation;
using AracKiralama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Business.Concretes
{
    public class RequestBusiness:IDisposable
    {
        public IList<Request> GetAll()
        {
            try
            {
                using (var r = new RequestRepository())
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
        public Request GetById(int id)
        {
            try
            {
                using (var r = new RequestRepository())
                {
                    var req = r.GetById(id);
                    return req;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public bool Delete(Request request)
        {
            try
            {
                using (var r = new RequestRepository())
                {
                    r.Delete(request);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
