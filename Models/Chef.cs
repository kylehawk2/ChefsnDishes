using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefsnDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}
        [Required]
        [MinLength(2, ErrorMessage="First Name must be at least two characters!")]
        [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage="First Name must can't be gibberish!")]
        public string First_Name {get;set;}
        [Required]
        [MinLength(2, ErrorMessage="Last Name must be at least two characters!")]
        [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage="Last Name can't be gibberish!")]
        public string Last_Name {get;set;}
        [Required]
        public DateTime Birthday {get;set;}
        public int Age
        {
            get { return DateTime.Now.Year - Birthday.Year; }
        }
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public List<Dish> Dishes {get;set;}
    }
}