using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VeggieRestaurantApp.Models
{
    public class EmailList
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        


        [ForeignKey("Diner")]
        [Display(Name = "Diner Id Number")]
        public int DinerId { get; set; }
        public Diner Diner { get; set; }

        [ForeignKey("Restaurant")]
        [Display(Name = "Restaurant Id Number")]
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
