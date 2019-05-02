using AracKiralama.Data.Implementation;
using AracKiralama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Business.Concretes
{
    public class UserBusiness:IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
        public UserBusiness()
        {
                
        }

        public bool Login(User user)
        {
            try
            {
                using (var userRepository = new UserRepository())
                {
                    if (userRepository.GetAll().Where(s => s.Username == user.Username && s.Password == user.Password).Count() == 1)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public IList<User> GetAll()
        {
            try
            {
                using (var userrepo = new UserRepository())
                {
                    var tempList = userrepo.GetAll();
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
