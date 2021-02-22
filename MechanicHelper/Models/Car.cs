using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicHelper.Models
{
    public class Car
    {
        public Car(int carId, string make, string model, DateTime built, int distance)
        {
            CarId = carId;
            Make = make;
            Model = model;
            Built = built;
            Distance = distance;
            Repairs = new List<RepairService>();
            Problems = new List<Problem>();
        }

        [Key]
        public int CarId { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public DateTime Built { get; set; }

        [Required]
        public int Distance { get; set; }

        public List<RepairService> Repairs { get; set; } = new List<RepairService>();

        public List<Problem> Problems { get; set; } = new List<Problem>();
    }
}