using Shop_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Demo.ListViewModels
{
    public class shoppingCartViewModel
    {
        public ShoppingCart  shoppingCart { get; set; }
        public decimal shopingCartTotal { get; set; }
    }
}
