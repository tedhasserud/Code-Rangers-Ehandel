using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Rangers_Ehandel
{
    public class Movies : Product
    {
        public Movies(string name, float price, string category, string resolution) : base(name, price, category)
        {
        }
    }
}
