using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VeggieRestaurantApp.Models
{
    public class EmailAddresses
    {
        [Key]
        public int Id { get; set; }
        public string EmailAddress { get; set; }

        [ForeignKey("Diner")]
        [Display(Name = "Diner Id Number")]
        public int DinerId { get; set; }
        public Diner diner { get; set; }
    }
}
