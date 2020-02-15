using System.Collections.Generic;
using WilsonTeaRoom.Models;

namespace WilsonTeaRoom.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}