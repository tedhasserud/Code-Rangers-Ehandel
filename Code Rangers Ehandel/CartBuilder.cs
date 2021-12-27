using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Rangers_Ehandel
{
    public class CartBuilder
    {
        public static ShoppingCart BookCart()
        {
            Book book1 = new Book(name: "fellowship of the Rings", price: 12, category: "book", genre: "fantasy", format: "hardcover", author: "jrr tolkien", isbn: "152485412");
            Book book2 = new Book(name: "the two towers", price: 12, category: "book", genre: "fantasy", format: "hardcover", author: "jrr tolkien", isbn: "152485451");
            Book book3 = new Book(name: "return of the king", price: 12, category: "book", genre: "fantasy", format: "hardcover", author: "jrr tolkien", isbn: "1524ff85412");

            List<Product> products = new List<Product>() { book1, book2, book3 };
            ShoppingCart cart = new ShoppingCart();
            cart.addManyItems(products);
            return cart;
        }
    }
}
