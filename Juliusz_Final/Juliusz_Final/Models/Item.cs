using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Juliusz_Final.Models
{
    public class Item
    {
        public int ID { get; set; }
        
        public int CategoryID { get; set; }

        [Required]
        public string Model { get; set; }
        
        public decimal Value { get; set; }
        
        [DefaultValue(1)]
        public double Condition { get; set; }

        public int? Size { get; set; }

        public Category Category { get; set; }

        public ICollection<Rent> Rents { get; set; }
    }
}
