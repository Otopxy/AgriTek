using System;
using System.ComponentModel.DataAnnotations;

namespace MyFarmer.Models
{
    public class FarmsFood
    {
        public int Id {get; set;}
        
        [Required]
        public Food FarmFood {get; set;}

        [Required]
        public Farm Farm {get; set;}

        [MinLength(1), MaxLength(500) ]
        public string Comments {get; set;} 
        public bool IsChecked { get; set; }
    }
}