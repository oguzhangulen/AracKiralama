using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Models
{
    [Table("RentedCars")]
    public class RentedCar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int OldKm { get; set; }
        [Required]
        public int NewKm { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public DateTime RentDate { get; set; }
        [Required]
        public DateTime DeliveryDate { get; set; }
        public bool IsActive { get; set; }

        public int carId { get; set; }

        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerSurname { get; set; }
        [Required]
        public int CustomerTC { get; set; }
    }
}
