using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WilsonTeaRoom.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int FoodId { get; set; }
        public int OrderQty { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Food Food { get; set; }
        public virtual Order Order { get; set; }

    }
}