using MechanicHelper.Areas.Identity.Data;
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
        private int RepairServiceId { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        private string Title { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        private string Description { get; set; }

        [Required]
        private int Price { get; set; }

        [Required]
        private bool IsDone { get; set; } = false;

        [Required]
        private int ServicedById { get; set; }

        private MechanicUser ServicedBy { get; set; }
    }
}