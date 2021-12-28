using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Rangers_Ehandel
{
    public class ShoppingCart
    {
        public static ShoppingCart cart;


        private List<Product> products = new List<Product>();

        public static ShoppingCart getCart()
        {
            if (cart == null)
            {
                cart = new ShoppingCart();
            }
            return cart;
        }

        public void AddItem(Product product)
        {
            products.Add(product);
        }
        public void addManyItems(List<Product> productsToAdd)
        {
            products.AddRange(productsToAdd);
        }

        public float getCost()
        {
            return products.Select(product => product.Price).Sum();
        }
        public string showItems()
        {
            foreach (Product product in products)
            {
                return "Product: " + product.Name;
            }
            return "empty";
        }

    }
}
