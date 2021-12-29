
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_Rangers_Ehandel;
using System.Windows.Forms;

namespace Code_Rangers_Ehandel
{
    public class User
    {
        private static User user;
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public List<Product> ActiveCart { get; } = new List<Product>();


        public User()
        {
            
        }

        public void BuyItem(Product product)
        {
            ActiveCart.Add(product);
        }

        public string ShowItems()
        {
            StringBuilder sb = new StringBuilder(); 

            foreach (Product product in ActiveCart)
            {
                sb.Append(product.Name + "\n");  
            }
            return sb.ToString();
        }
        private User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public User(string username)
        {
            Username = username;
        }
        private User(string username, string password, string name, string address, string email)
        {
            Username = username;
            Password = password;
            Name = name;
            Address = address;
            Email = email;
        }

        public static User getUser()
        {
            if (user == null)
            {
                user = new User();
            }
            return user;
        }

        public static User getUser(string username)
        {
            if (user == null)
            {
                user = new User(username);
            }
            return user;
        }
        public static User getInstance(string username, string password)
        {
            if (user == null)
            {
                user = new User(username, password);
            }
            return user;
        }
        public static User getInstance(string username, string password, string name, string address, string email)
        {
            if (user == null)
            {
                user = new User(username, password, name, address, email);
            }
            return user;
        }
     
    }
}
