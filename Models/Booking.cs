using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watches.Models
{
    public class Booking
    {
        public int BrandID { get; set; }//customer id
        public Brand Brand { get; set; }//add relation of customer table


        public int CustomerID { get; set; }//add menu id
        public Customer Customer { get; set; }//add relation of menu table
        public int BookingID { get; set; }

      

        public string DeliveryAdress { get; set; }

        public int  Quantity  { get; set; }


        public DateTime BookingDate { get; set; }
    }
}
