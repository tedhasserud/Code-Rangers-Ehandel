using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Rangers_Ehandel
{
    public class Book : Product
    {
        public Book(string name, float price, string category, string genre, string format, string author, string isbn) : base(name, price, category)
        {
        }
    }
}
