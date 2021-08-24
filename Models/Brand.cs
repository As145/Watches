using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Watches.Models
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }

        public string Name { get; set; }


        public string Model { get; set; }

        public decimal Price { get; set; }

        public decimal Rating { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
