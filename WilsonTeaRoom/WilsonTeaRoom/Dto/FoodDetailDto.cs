using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WilsonTeaRoom.Dto
{
    public class FoodDetailDto
    {
        public int ID { get; set; }

        public string CategoryName { get; set; }

        public int CategoryId { get; set; }

        [Required(ErrorMessage = "An Item Name is required")]
        [StringLength(255, MinimumLength = 2)]
        public string Name { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 999.99, ErrorMessage = "Price must be between 0.01 and 999.99")]
        public decimal Price { get; set; }

        public bool IsVisible { get; set; }
    }
}