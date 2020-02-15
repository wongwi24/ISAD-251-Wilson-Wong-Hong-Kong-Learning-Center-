using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WilsonTeaRoom.Models
{
    public class Category
    {
        [DisplayName("Category ID")]
        public int ID { get; set; }

        [DisplayName("Category")]
        public string Name { get; set; }

        public virtual ICollection<Food> Foods { get; set; }
    }
}