using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Juliusz_Final.Models
{
    public class Rent
    {
        public int ID { get; set; }
        
        public int CustomerID { get; set; }
        
        public int ItemId { get; set; }

        public double ItemCondition { get; set; }

        [Required]
        public DateTime RentDate { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public DateTime? ReturnDate { get; set; }


        public Customer Customer { get; set; }

        public Item Item { get; set; }
    }
}
