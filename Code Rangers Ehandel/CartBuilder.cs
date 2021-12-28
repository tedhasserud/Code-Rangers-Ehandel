using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Rangers_Ehandel
{
    public class CartBuilder
    {
        public static ShoppingCart Cart()
        {
            List<Product> products = new List<Product>();
            ShoppingCart cart = new ShoppingCart();
            cart.addManyItems(products);
            return cart;
        }
    }
}
