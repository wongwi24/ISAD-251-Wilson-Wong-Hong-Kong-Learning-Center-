using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WilsonTeaRoom.Dto
{
    public class FoodDto
    {
        public int ID { get; set; }

        public string Category { get; set; }

        public int CategoryId { get; set; }

        [Required(ErrorMessage = "An Item Name is required")]
        [StringLength(255, MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 999.99, ErrorMessage = "Price must be between 0.01 and 999.99")]
        public decimal Price { get; set; }
    }
}