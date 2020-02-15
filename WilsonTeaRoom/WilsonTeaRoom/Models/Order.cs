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
    public class Order
    {
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }

        public System.DateTime OrderDate { get; set; }
       
        public string Username { get; set; }

        [Required(ErrorMessage = "Your Name is required")]
        [StringLength(255, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Your Name is required")]
        [StringLength(255, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Your Phone Number is required")]
        [StringLength(20, MinimumLength = 8)]
        public string Phone { get; set; }

        public decimal Total { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}