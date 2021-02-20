using MechanicHelper.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MechanicHelper.Models
{
    public class Car
    {
        [Key]
        private int CarId { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        private string Make { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        private string Model { get; set; }

        [Required]
        private int OwnerId { get; set; }

        [Required]
        private MechanicUser Owner { get; set; }

        [Required]
        private DateTime Built { get; set; }

        private List<RepairService> RepairServices { get; set; }
    }
}