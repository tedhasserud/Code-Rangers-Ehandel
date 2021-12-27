using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private User(string username, string password)
        {
            username = Username;
            password = Password;
        }
        private User(string username, string password, string name, string address, string email)
        {
            username = Username;
            password = Password;
            name = Name;
            address = Address;
            email = Email;
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
