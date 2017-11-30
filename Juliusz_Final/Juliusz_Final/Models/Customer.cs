using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Juliusz_Final.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int? Height { get; set; }
        public int? Skill { get; set; }
        public DateTime? BirthDate { get; set; }

        public ICollection<Rent> Rents { get; set; }
    }
}
