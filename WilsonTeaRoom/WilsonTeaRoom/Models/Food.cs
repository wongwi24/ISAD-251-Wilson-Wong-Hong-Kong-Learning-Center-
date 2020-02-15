using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Web.Mvc.Html;

namespace WilsonTeaRoom.Models
{
    public class Food
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [DisplayName("Category")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "An Item Name is required")]
        [StringLength(255, MinimumLength =2)]
        public string Name { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 999.99, ErrorMessage = "Price must be between 0.01 and 999.99")]
        public decimal Price { get; set; }

        [DisplayName("Food Picture URL")]
        [StringLength(1024)]
        public string FoodPictureUrl { get; set; }

        [DefaultValue(true)]
        public bool IsVisible { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}