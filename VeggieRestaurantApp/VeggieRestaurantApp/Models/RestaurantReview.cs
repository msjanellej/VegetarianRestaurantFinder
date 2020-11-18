using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VeggieRestaurantApp.Models
{
    public class RestaurantReview
    {
        [Key]
        public int Id { get; set; }
        public string Review{ get; set; }
        public int Likes { get; set; }

        [ForeignKey("Diner")]
        [Display(Name = "Diner Id Number")]
        public int DinerId { get; set; }
        public Diner diner { get; set; }

        [ForeignKey("Restaurant")]
        [Display(Name = "Restaurant Id Number")]
        public int RestaurantId { get; set; }
        public Restaurant restaurant { get; set; }
    }
}
