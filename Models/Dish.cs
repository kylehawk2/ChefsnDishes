using System;
using System.ComponentModel.DataAnnotations;

namespace ChefsnDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}
        [Required]
        [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage="Dish name cannot be gibberish!")]
        [MinLength(2, ErrorMessage="Dish Name must be at least two characters!")]
        public string Name {get;set;}
        [Required]
        [Range(0,5000, ErrorMessage="Calories cannot exceed 5000 or negative.")]
        public int Calories {get;set;}
        [Required]
        [MinLength(5)]
        public string Description {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        [Required]
        public int ChefId {get;set;}
        public Chef Creator {get;set;}
    }
}