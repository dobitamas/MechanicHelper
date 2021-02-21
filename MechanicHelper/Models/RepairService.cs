using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicHelper.Models
{
    public class RepairService
    {
        [Key]
        public Guid RepairServiceId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime DateOfRepair { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        [ForeignKey("ServicedOn")]
        public Guid ServicedOnId { get; set; }

        [Required]
        public Car ServicedOn { get; set; }

        public RepairService()
        {
        }
    }
}