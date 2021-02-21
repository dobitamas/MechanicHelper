using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicHelper.Models
{
    public class Car
    {
        [Key]
        public string CarId { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public DateTime Built { get; set; }

        [Required]
        public int Distance { get; set; }

        public ICollection<RepairService> Repairs { get; set; }
    }
}