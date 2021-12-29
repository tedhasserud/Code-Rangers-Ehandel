using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Rangers_Ehandel
{
    class Record : Product
    {
        public Record(string name, float price, string category, string genre, string artist, string format, int itemNumber) : base(name, price, category) 
        {
        }
    }
}
