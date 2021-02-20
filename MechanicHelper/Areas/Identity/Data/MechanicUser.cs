using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MechanicHelper.Models;
using Microsoft.AspNetCore.Identity;

namespace MechanicHelper.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the MechanicUser class
    public class MechanicUser : IdentityUser
    {
        [Key]
        private int MehcanicUserId { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        private string Name { get; set; }

        [Required]
        private DateTime BirthDay { get; set; }

        [Required]
        private DateTime Registered { get; set; }

        private List<Car> cars { get; set; }
    }
}