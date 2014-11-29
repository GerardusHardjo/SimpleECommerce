using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CS4389Bookstore.Models;

namespace CS4389Bookstore.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}