using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VeggieRestaurantApp.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string RecipeURL { get; set; }
        public string Image { get; set; }
        public int Likes { get; set; }
        

        [ForeignKey("Diner")]
        [Display(Name = "Diner Id Number")]
        public int DinerId { get; set; }
        public Diner diner { get; set; }

    }
}
