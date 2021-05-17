using Microsoft.AspNetCore.Identity;
using Project.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class CustomIdentityUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [Required]
        public string Phone { get; set; }
        public int CountedID { get; set; }
        public string img { get; set; } = "https://upload.wikimedia.org/wikipedia/commons/7/7c/Profile_avatar_placeholder_large.png";
        public DateTime DateOfJoin { get; set; }
        public Nullable<bool> IsAdmin { get; set; }


        public virtual List<Order> Orders { get; set; }
    }
}
