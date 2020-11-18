using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VeggieRestaurantApp.Models
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }

        [ForeignKey("Restaurant")]
        [Display(Name = "Restaurant Id Number")]
        public int RestaurantId { get; set; }
        public Restaurant restaurant { get; set; }

    }
}
