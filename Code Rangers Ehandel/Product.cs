using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Rangers_Ehandel
{
    public class Product
    {
        public string Name;
        public float Price;
        public string Category;

        public Product(string name, float price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }

}
