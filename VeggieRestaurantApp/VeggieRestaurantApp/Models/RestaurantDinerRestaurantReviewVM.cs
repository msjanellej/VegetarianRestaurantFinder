using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VeggieRestaurantApp.Models
{
    public class RestaurantDinerRestaurantReviewVM
    {
        [Key]
        public int ID { get; set; }
        public Restaurant RestaurantVM { get; set; }
        public Diner DinerVM { get; set; }
        public RestaurantReview RestaurantReviewVM { get; set; }

    }
}
