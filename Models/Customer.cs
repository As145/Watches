using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Watches.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        public string Name { get; set; }


        public  string Address { get; set; }

        public int Phone { get; set; } 


        public string  timetaken { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
