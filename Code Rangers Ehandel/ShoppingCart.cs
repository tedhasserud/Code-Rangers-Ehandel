using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Rangers_Ehandel
{
    public class ShoppingCart
    {
        private List<Product> products = new List<Product>();

        public void addManyItems(List<Product> productsToAdd)
        {
            products.AddRange(productsToAdd);
        }


        public float getCost()
        {
            return products.Select(product => product.Price).Sum();
        }
        public void showItems()
        {
            foreach (Product product in products)
            {
                Console.WriteLine("Product: " + product);
            }
        }

    }
}
