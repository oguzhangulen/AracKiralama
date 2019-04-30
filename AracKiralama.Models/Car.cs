using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Models
{
    [Table("Cars")]
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public bool IsAvailable { get; set; }
        [Required]
        public string CarName { get; set; }
        [Required]
        public string CarModel { get; set; }
        [Required]
        public int DriverLicenseAge { get; set; }
        [Required]
        public int MinAge { get; set; }
        [Required]
        public int DailyKmLimit { get; set; }
        [Required]
        public int CurrentKm { get; set; }
        [Required]
        public bool Airbag { get; set; }
        [Required]
        public decimal BaggageCapacity { get; set; }
        [Required]
        public int SeatCount { get; set; }
        [Required]
        public decimal DailyPrice { get; set; }

        public virtual Company Company { get; set; }
    }
}
