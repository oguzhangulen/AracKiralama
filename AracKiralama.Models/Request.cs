using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Models
{
    [Table("Requests")]
    public class Request
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime RentDate { get; set; }
        [Required]
        public DateTime DeliveryDate { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerSurname { get; set; }
        [Required]
        public int CustomerTC { get; set; }

        public virtual Car Car { get; set; }
    }
}
