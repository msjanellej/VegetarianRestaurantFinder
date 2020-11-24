using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VeggieRestaurantApp.Models
{
    public class Diner
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        [Display(Name = "Birth Month")]
        public string BirthMonth { get; set; }
        [Display(Name = "Anniversary Month")]
        public string AnniversaryMonth { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }



    }
}
