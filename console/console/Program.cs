using AracKiralama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net;

namespace console
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }
        static async Task<Uri> CreateCarAsync(Car car)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("api/Cars", car);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }
        static async Task<Uri> CreateRentedCarAsync(RentedCar car)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("api/Rentacar", car);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }
        static async Task RunAsync()
        {
            client.BaseAddress = new Uri("http://localhost:49310/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                string i = "";
                Console.WriteLine("Yeni araç eklemek için (1)\nAraç kiralamak için (2)\n");
                i=Console.ReadLine();
                if(i=="1")
                {
                    Car car = new Car();
                    Console.Write("Airbag:");
                    car.Airbag =Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("BaggageCapacity:");
                    car.BaggageCapacity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("CarModel:");
                    car.CarModel = Console.ReadLine();
                    Console.WriteLine("CarName:");
                    car.CarName=Console.ReadLine();
                    Console.WriteLine("CompanyId:");
                    car.CompanyId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("CurrentKm:");
                    car.CurrentKm = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("DailyKmLimit:");
                    car.DailyKmLimit = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("DailyPrice:");
                    car.DailyPrice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("DriverLicenseAge:");
                    car.DriverLicenseAge = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("MinAge:");
                    car.MinAge = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("SeatCount:");
                    car.SeatCount = Convert.ToInt32(Console.ReadLine());
                    var url = await CreateCarAsync(car);
                    Console.WriteLine($"Created at {url}");
                }
                else if(i=="2")
                {
                    RentedCar car = new RentedCar();
                    Console.WriteLine("Car Id:");
                    car.carId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("CustomerName:");
                    car.CustomerName = Console.ReadLine();
                    Console.WriteLine("CustomerSurname:");
                    car.CustomerSurname = Console.ReadLine();
                    Console.WriteLine("CustomerTC:");
                    car.CustomerTC = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("DeliveryDate:");
                    car.DeliveryDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("RentDate:");
                    car.RentDate = Convert.ToDateTime(Console.ReadLine());
                    var url = await CreateRentedCarAsync(car);
                    Console.WriteLine($"Created at {url}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
