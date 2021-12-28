using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Rangers_Ehandel
{
    public class Monitor : Product
    {
        public Monitor(string name, string category, string brand, float price, string screenSize, string refreshRate, bool HDR) : base(name, price, category)
        {
        }
    }
}
