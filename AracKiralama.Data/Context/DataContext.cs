using AracKiralama.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Data.Context
{
    public class DataContext:DbContext
    {
        public DataContext():base("DataContext")
        {

        }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RentedCar> RentedCars { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
