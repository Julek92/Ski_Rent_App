using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Juliusz_Final.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Required]
        public string Type { get; set; }
        
        public int RentDivider { get; set; }


        public ICollection<Item> Items { get; set; }
    }
}
