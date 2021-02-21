using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicHelper.Models
{
    public class Problem
    {
        [Key]
        public Guid ProblemId { get; set; }

        [Required]
        public DateTime AddedOn { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public bool IsDone { get; set; } = false;

        [Required]
        [ForeignKey("ProblemOn")]
        public Guid ProblemOnId { get; set; }

        [Required]
        public Car ProblemOn { get; set; }
    }
}